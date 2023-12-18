using System.Diagnostics;
using ECM.WebApp.Data.Contexto;
using ECM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECM.WebApp.Controllers
{
    public class AutenticationController : Controller
    {
        private readonly Contexto _contexto;
        private readonly DbSet<Usuario> _entityUsuario;
        public AutenticationController()
        {
            _contexto = new Contexto();
            _entityUsuario = _contexto.Set<Usuario>();
        }

        public IActionResult Index()
        {
            var result = _entityUsuario.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Login(string mail, string senha)
        {
            var query = _entityUsuario.Where(i => i.Mail == mail && i.Senha == senha).ToList();

            if (query.Any())
            {
                return Json(new { status = 1, message = Url.Action("Index", "Home") });
            }
            else
            {
                return Json(new { status = 0, message = "Email ou senha invalido" });
            }
        }

        [HttpPost]
        public IActionResult Register(string name, string mail, string pass, int familyId)
        {
            if (!_entityUsuario.Where(x => x.Mail == mail).Any())
            {
                _entityUsuario.Add(new Usuario()
                {
                    UsuarioID = _entityUsuario.Count() + 1,
                    NomeUser = name,
                    Mail = mail,
                    Senha = pass,
                    FamiliaID = familyId
                });
                _contexto.SaveChanges();
                return Json(new { status = 1, message = "Usuario cadastrado." });
            }
            return Json(new { status = 0, message = "Email ja utilizado." });
        }

        [HttpPost]
        public IActionResult Alter(string mail, string pass)
        {
            _entityUsuario.Where(x => x.Mail == mail).First().Senha = pass;
            _contexto.SaveChanges();
            return Json(new { status = 1, message = "Senha alterada." });
        }
    }
}
