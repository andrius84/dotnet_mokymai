using Microsoft.EntityFrameworkCore;

namespace Paskaita_3_EntityFramework
{
    public class ProjektasContext : DbContext
    {
        public ProjektasContext() : base()
        {
        }
        public ProjektasContext(DbContextOptions<ProjektasContext> options) : base(options)
        {
        }
        public DbSet<Projektas> Projektai { get; set; }
        public DbSet<Skyrius> Skyriai { get; set; }
        public DbSet<Darbuotojas> Darbuotojai { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=ProjektasDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
