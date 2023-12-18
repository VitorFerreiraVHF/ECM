using System.Diagnostics;
using ECM.WebApp.Data.Contexto;
using ECM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECM.WebApp.Controllers
{
    public class UserEditController : Controller
    {
        private readonly Contexto _contexto;
        private readonly DbSet<Familia> _entityFamilia;
        public UserEditController()
        {
            _contexto = new Contexto();
            _entityFamilia = _contexto.Set<Familia>();
        }
        public IActionResult Index()
        {   
            var lst = _entityFamilia.ToList();
            return View(lst);
        }
    }
}
