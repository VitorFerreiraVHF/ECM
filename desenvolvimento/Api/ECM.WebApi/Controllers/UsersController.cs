using System.Net;
using ECM.Dominio.Interfaces.Repositorios;
using ECM.Dominio.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace ECM.WebApi.Controllers
{

    [ApiController]
    public class UsersController : Controller
    {
        //private readonly IUserService _userService;
        //public UsersController(IUserService userService)
        //{
        //    _userService = userService;
        //}
        [HttpGet]
        [Route("/cadastro")]
        public IActionResult Cadastro()
        {
            return Ok();
        }

        [HttpGet]
        [Route("/login")]
        public ActionResult login( string email, string senha)
        {
            //return View("");
            return RedirectPermanent("file:///D:/ECONOMII/ECM/desenvolvimento///home.html");
        }
    }
}

