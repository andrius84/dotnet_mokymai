using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paskaita_5_data_seed.Entities;

namespace Paskaita_5_data_seed
{

    public class BookContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=BookDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasData(CsvHelperService.GetGenres());
            modelBuilder.Entity<Publisher>()
                .HasData(CsvHelperService.GetPublishers());
            modelBuilder.Entity<Country>()
                .HasData(CsvHelperService.GetCountries());
            modelBuilder.Entity<Book>()
                .HasData(CsvHelperService.GetBooks());
            modelBuilder.Entity<Author>()
                .HasData(CsvHelperService.GetAuthors());
        }
    }
}
