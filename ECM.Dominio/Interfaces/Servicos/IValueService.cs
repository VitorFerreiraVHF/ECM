using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.Dominio.Interfaces.Servicos
{
    public interface IValueService
    {
        ValidationResult Cadastro(ValueViewModel value);
    }
}
