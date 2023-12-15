using ECM.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECM.WebApp.Data.Configuracao
{
    public class FamiliaConfiguracao : IEntityTypeConfiguration<Familia>    
    {
        public void Configure(EntityTypeBuilder<Familia> builder)
        {
            builder.ToTable("Familia", "ECM");
            builder.HasKey(t => t.FamiliaID);
            builder.Property(t => t.FamiliaID).HasColumnName("FamiliaID");
            builder.Property(t => t.NomeFamilia).HasColumnName("NomeFamilia");

        }
    }
}
