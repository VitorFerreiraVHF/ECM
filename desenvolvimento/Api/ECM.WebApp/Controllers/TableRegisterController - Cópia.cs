using System.Diagnostics;
using ECM.WebApp.Data.Contexto;
using ECM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECM.WebApp.Controllers
{
    public class TableRegisterController : Controller
    {
        private readonly Contexto _contexto;
        private readonly DbSet<Lancamentos> _entityLancamentos;
        public TableRegisterController()
        {
            _contexto = new Contexto();
            _entityLancamentos = _contexto.Set<Lancamentos>();
        }
        public IActionResult Index()
        {
            var lst = _entityLancamentos.ToList();
            return View(lst);
        }
    }
}
