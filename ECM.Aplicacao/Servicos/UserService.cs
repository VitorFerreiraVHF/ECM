using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Dominio.Interfaces.Repositorios;
using ECM.Dominio.Interfaces.Servicos;

namespace ECM.Aplicacao.Servicos
{
    public class UserService
    {
        private readonly IUserRepository _userRepository; 
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
