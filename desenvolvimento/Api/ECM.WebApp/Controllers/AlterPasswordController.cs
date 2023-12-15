using System.Diagnostics;
using ECM.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECM.WebApp.Controllers
{
    public class AlterPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
