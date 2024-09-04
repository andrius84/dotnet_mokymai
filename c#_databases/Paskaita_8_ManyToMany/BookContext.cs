using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Paskaita_8_ManyToMany.Entities;


namespace Paskaita_8_ManyToMany
{
    public class BookContext : DbContext
    {
        public static bool IsSeeding = true;
        public BookContext() : base()
        {
        }
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Books8;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("BookCategories");
                entity.Property(c => c.CategoryId).HasColumnName("Id");
                entity.Property(c => c.Name).HasColumnName("CategoryName");
                entity.HasData(CsvHelperService.GetCategories());
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("LibraryBooks");
                entity.Property(b => b.BookId).HasColumnName("Id");
                entity.Property(b => b.Name).HasColumnName("Name2");
                entity.Property(b => b.Year).HasColumnName("Year2");
                entity.HasData(CsvHelperService.GetBooks());
            });

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Categories)
                .WithMany(c => c.Books)
                .UsingEntity(j =>
                {
                    j.ToTable("BookCategory");
                    j.HasData(CsvHelperService.GetBooksAndCategories());
                });
        }
    }
}
