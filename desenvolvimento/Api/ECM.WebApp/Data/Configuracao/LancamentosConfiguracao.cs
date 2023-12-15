using ECM.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECM.WebApp.Data.Configuracao
{
    public class LancamentosConfiguracao : IEntityTypeConfiguration<Lancamentos>    
    {
        public void Configure(EntityTypeBuilder<Lancamentos> builder)
        {
            builder.ToTable("Lancamentos", "ECM");
            builder.HasKey(t => t.LancamentoID);
            builder.Property(t => t.LancamentoID).HasColumnName("LancamentoID");
            builder.Property(t => t.NomeLancamento).HasColumnName("NomeLancamento");
            builder.Property(t => t.ValorTotal).HasColumnName("ValorTotal");
            builder.Property(t => t.ValorFinal).HasColumnName("ValorFinal");
            builder.Property(t => t.DataInicial).HasColumnName("DataInicial");
            builder.Property(t => t.DataFinal).HasColumnName("DataFinal");
            builder.Property(t => t.FamiliaID).HasColumnName("FamiliaID");

        }
    }
}
