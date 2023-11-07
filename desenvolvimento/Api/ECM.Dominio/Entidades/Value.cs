using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.Dominio.Entidades
{
    internal class Value
    {
        public int iduser { get; set; }
        public int IdValue { get; set; }
        public string NameObjetivo { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFim { get; set; }
        public float Objetivo { get; set; }
        public float Valor { get; set; }
    }
}
