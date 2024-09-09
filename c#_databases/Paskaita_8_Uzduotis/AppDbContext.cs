using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paskaita_8_Uzduotis.Entities;

namespace Paskaita_8_Uzduotis
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
        }
        public DbSet<FileModel> Files { get; set; }
        public DbSet<FolderModel> Folders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=FilesDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileModel>()
                .HasOne(f => f.Folder)
                .WithMany(f => f.Files)
                .HasForeignKey(f => f.FolderId);
        }
    }
}
