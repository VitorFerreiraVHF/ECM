namespace ECM.WebApp.Models
{
    public class Lancamentos
    {
        public int LancamentoID { get; set; }
        public string NomeLancamento { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorFinal { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int FamiliaID { get; set; }

    }
}

