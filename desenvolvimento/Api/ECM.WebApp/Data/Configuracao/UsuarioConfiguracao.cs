using ECM.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECM.WebApp.Data.Configuracao
{
    public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>    
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario", "ECM");
            builder.HasKey(t => t.UsuarioID);
            builder.Property(t => t.UsuarioID).HasColumnName("UsuarioID");
            builder.Property(t => t.NomeUser).HasColumnName("NomeUser");
            builder.Property(t => t.Mail).HasColumnName("Mail");
            builder.Property(t => t.Senha).HasColumnName("Senha");
            builder.Property(t => t.FamiliaID).HasColumnName("FamiliaID");

        }
    }
}
