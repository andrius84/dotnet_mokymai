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
        public static bool IsSeeding = false;
        public BookContext() : base()
        {
        }
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Books10;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Categories"); 
                entity.Property(c => c.CategoryId).HasColumnName("Id"); 
                entity.Property(c => c.Name).HasColumnName("CategoryName"); 
                entity.HasData(CsvHelperService.GetCategories()); 
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Books");
                entity.Property(b => b.BookId).HasColumnName("Id"); 
                entity.Property(b => b.Name).HasColumnName("BookName"); 
                entity.Property(b => b.Year).HasColumnName("BookYear"); 
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

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Authors"); 
                entity.Property(a => a.AuthorId).HasColumnName("Id");  
                entity.HasData(CsvHelperService.GetAuthors()); 
            });

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany(c => c.Books)
                .UsingEntity(j =>
                {
                    j.ToTable("BookAuthor");
                    j.HasData(CsvHelperService.GetBooksAndAuthors());
                });

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 3, FirstName = "N.K.", LastName = "Jemisin" },
                new Author { AuthorId = 4, FirstName = "Brandon", LastName = "Sanderson" },
                new Author { AuthorId = 5, FirstName = "Patrick", LastName = "Rothfuss" },
                new Author { AuthorId = 6, FirstName = "Joe", LastName = "Abercrombie" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 8, Name = "The Fifth Season", Year = 2015 },
                new Book { BookId = 9, Name = "Mistborn: The Final Empire", Year = 2006 },
                new Book { BookId = 10, Name = "The Name of the Wind", Year = 2007 },
                new Book { BookId = 11, Name = "The Way of Kings", Year = 2010 },
                new Book { BookId = 12, Name = "Red Sister", Year = 2017 },
                new Book { BookId = 13, Name = "The Blade Itself", Year = 2009 },
                new Book { BookId = 14, Name = "The Heroes", Year = 2011 }
            );

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .UsingEntity(j =>
                {
                    j.ToTable("BookAuthor");
                    j.HasData(
                        new { BooksBookId = 8, AuthorsAuthorId = 3 },
                        new { BooksBookId = 9, AuthorsAuthorId = 4 },
                        new { BooksBookId = 10, AuthorsAuthorId = 5 },
                        new { BooksBookId = 11, AuthorsAuthorId = 4 },
                        new { BooksBookId = 12, AuthorsAuthorId = 6 },
                        new { BooksBookId = 13, AuthorsAuthorId = 6 },
                        new { BooksBookId = 14, AuthorsAuthorId = 6 },
                        new { BooksBookId = 8, AuthorsAuthorId = 4 },
                        new { BooksBookId = 10, AuthorsAuthorId = 4 },
                        new { BooksBookId = 12, AuthorsAuthorId = 5 }
                    );
                });
        }
    }
}
