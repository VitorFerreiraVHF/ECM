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
        public IActionResult Login(string mail, string senha)
        {
            var query = _entityUsuario.Where(i => i.Mail == mail && i.Senha == senha).ToList();

            if (query.Any())
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return RedirectToAction("Index", "Autentication");
            }

            //Codigo pra registrar um novo usuarios

            //var obj = new Usuario()
            //{
            //    NomeUser = "thiago",
            //    Mail = "thiago@gmail.com",
            //    Senha = "123456789",
            //    FamiliaID = 2,
            //    UsuarioID = 0
            //};

            //if(mail existe && senha existe)

            //Atualizar
            //var ent = _entityUsuario.Where(c => c.UsuarioID == usuarioId).Add(obj);

            //else
                //Salvar
                //obj.UsuarioID = _entityUsuario.Count() + 1;
                //var ent = _entityUsuario.Add(obj);
            //

            //Confirma Auteração
            //_contexto.SaveChanges();
        }
    }
}
