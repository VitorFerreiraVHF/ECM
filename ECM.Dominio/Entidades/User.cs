using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.Dominio.Entidades
{
    public class User
    {
        public int iduser { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
    }
}
