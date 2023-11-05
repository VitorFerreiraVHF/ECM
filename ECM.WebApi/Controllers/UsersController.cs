using ECM.Dominio.Interfaces.Repositorios;
using ECM.Dominio.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace ECM.WebApi.Controllers
{

    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserService(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
