using Microsoft.AspNetCore.Mvc;

namespace ECM.WebApi.Controllers
{
    public class ValueController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
