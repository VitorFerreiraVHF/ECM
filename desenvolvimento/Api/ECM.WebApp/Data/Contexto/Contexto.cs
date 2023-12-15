using ECM.WebApp.Data.Configuracao;
using ECM.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ECM.WebApp.Data.Contexto
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source = 10.107.176.41,1434; Database= BD040338; User ID = RA040338; Password = 040338");
            optionsBuilder.UseSqlServer(@"Data Source = 201.62.57.93,1434; Database= BD040338; User ID = RA040338; Password = 040338");
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Lancamentos> Lancamentos { get; set; }
        public DbSet<Familia> Familia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());
            modelBuilder.ApplyConfiguration(new FamiliaConfiguracao());
            modelBuilder.ApplyConfiguration(new LancamentosConfiguracao());
        }
    }
}


