using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Paskaita_3_EntityFramework.Entities;

namespace Paskaita_3_EntityFramework
{
    public class BookContext : DbContext
    {
        public BookContext() : base()
        {
        }
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=BookDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
