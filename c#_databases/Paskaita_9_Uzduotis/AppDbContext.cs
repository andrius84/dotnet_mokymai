using Microsoft.EntityFrameworkCore;
using Paskaita_9_Uzduotis.Entities;

namespace Paskaita_9_Uzduotis
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Manager> Managers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=AppDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Department and Employees
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithOne();

            // Project and Employees (many-to-many)
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Employees)
                .WithMany(e => e.Projects)
                .UsingEntity(j => j.ToTable("EmployeeProjects")); // Optional: Use a junction table name

            // Company and Projects (many-to-many)
            modelBuilder.Entity<Company>()
                .HasMany(c => c.Projects)
                .WithMany(p => p.Companies)
                .UsingEntity(j => j.ToTable("CompanyProjects")); // Optional: Use a junction table name

            // Manager and Department (one-to-one)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithOne();
        }
    }
}
