using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzduotis_10.Entities;

namespace Uzduotis_10
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() : base()
        {
        }
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
        }
        public DbSet<Pacientas> Pacientai { get; set; }
        public DbSet<Gydytojas> Gydytojai { get; set; }
        public DbSet<Specializacija> Specializacijos { get; set; }
        public DbSet<Vizitas> Vizitai { get; set; }
        public DbSet<Diagnoze> Diagnozes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Poliklinika;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pacientas>().ToTable("Pacientai");
            modelBuilder.Entity<Gydytojas>().ToTable("Gydytojai");
            modelBuilder.Entity<Specializacija>().ToTable("Specializacijos");
            modelBuilder.Entity<Vizitas>().ToTable("Vizitai");
            modelBuilder.Entity<Diagnoze>().ToTable("Diagnozes");

            modelBuilder.Entity<Pacientas>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Gydytojas>()
                .HasKey(g => g.Id);
            modelBuilder.Entity<Specializacija>()
                .HasKey(s => s.Id);
            modelBuilder.Entity<Vizitas>()
                .HasKey(v => v.Id);
            modelBuilder.Entity<Diagnoze>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Pacientas>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Gydytojas>()
                .Property(g => g.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Specializacija>()
                .Property(s => s.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Vizitas>()
                .Property(v => v.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Diagnoze>()
                .Property(d => d.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Gydytojas>()
                .HasOne(g => g.Specializacija)
                .WithOne(s => s.Gydytojas)
                .HasForeignKey<Specializacija>(s => s.GydytojasId);

            modelBuilder.Entity<Gydytojas>()
                .HasMany(g => g.Vizitai)
                .WithOne(v => v.Gydytojas)
                .HasForeignKey(v => v.GydytojasId);

            modelBuilder.Entity<Pacientas>()
                .HasMany(p => p.Vizitai)
                .WithOne(v => v.Pacientas)
                .HasForeignKey(v => v.PacientasId);

            modelBuilder.Entity<Diagnoze>()
                .HasMany(d => d.Vizitai)
                .WithOne(v => v.Diagnoze)
                .HasForeignKey(v => v.DiagnozeId);

            modelBuilder.Entity<Gydytojas>()
                .HasMany(d => d.Pacientai)
                .WithMany(p => p.Gydytojai)
                .UsingEntity<Vizitas>(
                    j => j
                        .HasOne(a => a.Pacientas)
                        .WithMany(p => p.Vizitai)
                        .HasForeignKey(a => a.PacientasId),
                    j => j
                        .HasOne(a => a.Gydytojas)
                        .WithMany(d => d.Vizitai)
                        .HasForeignKey(a => a.GydytojasId),
                    j =>
                    {
                        j.HasKey(a => a.Id);
                    });
        }
    }
}
