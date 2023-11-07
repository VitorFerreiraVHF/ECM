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
        public IActionResult login( string email, string senha)
        {
            return Redirect("");
        }
    }
}

