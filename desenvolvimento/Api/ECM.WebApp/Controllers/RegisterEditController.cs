using System.Diagnostics;
using ECM.WebApp.Data.Contexto;
using ECM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECM.WebApp.Controllers
{
    [Route("RegisterEdit")]
    public class RegisterEditController : Controller
    {
        private readonly Contexto _contexto;
        private readonly DbSet<Lancamentos> _entityLancamentos;
        public RegisterEditController()
        {
            _contexto = new Contexto();
            _entityLancamentos = _contexto.Set<Lancamentos>();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Index([FromRoute]int id)
        {
            var ent = _entityLancamentos.Where(x => x.LancamentoID == id);
            if(ent.Any())
                return View(ent.First());
            else 
                return View(new Lancamentos());
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _entityLancamentos.Remove(_entityLancamentos.Where(x => Id == x.LancamentoID).First());
            _contexto.SaveChanges();
            return Json(new { status = 1, message = "Deletado com sucesso" });
        }
    }
}
