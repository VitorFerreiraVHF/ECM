using System.Diagnostics;
using ECM.WebApp.Data.Contexto;
using ECM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECM.WebApp.Controllers
{
    public class RegisterController : Controller
    {
        private readonly Contexto _contexto;
        private readonly DbSet<Lancamentos> _entityLancamentos;
        public RegisterController()
        {
            _contexto = new Contexto();
            _entityLancamentos = _contexto.Set<Lancamentos>();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addLancamento(
            string NomeLancamento,
            DateTime DataInicial,
            DateTime DataFinal,
            string valorTotal,
            string valorFinal
        ) {
            _entityLancamentos.Add(new Lancamentos() {
                NomeLancamento = NomeLancamento,
                DataInicial = DataInicial,
                DataFinal = DataFinal,
                ValorTotal = decimal.Parse(valorTotal.Replace(',', '.')),
                ValorFinal = decimal.Parse(valorTotal.Replace(',', '.')),
                LancamentoID = _entityLancamentos.Count() + 1,
                FamiliaID = 1
            }); ;
            _contexto.SaveChanges();
            return RedirectToAction("Index", "Register");
        }  
    }
}
