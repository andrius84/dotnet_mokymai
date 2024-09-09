﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Paskaita_8_ManyToMany;

#nullable disable

namespace Paskaita_8_ManyToMany.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsAuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthorId", "BooksBookId");

                    b.HasIndex("BooksBookId");

                    b.ToTable("BookAuthor", (string)null);

                    b.HasData(
                        new
                        {
                            AuthorsAuthorId = 1,
                            BooksBookId = 1
                        },
                        new
                        {
                            AuthorsAuthorId = 2,
                            BooksBookId = 1
                        },
                        new
                        {
                            AuthorsAuthorId = 1,
                            BooksBookId = 2
                        },
                        new
                        {
                            AuthorsAuthorId = 1,
                            BooksBookId = 3
                        },
                        new
                        {
                            AuthorsAuthorId = 2,
                            BooksBookId = 4
                        },
                        new
                        {
                            AuthorsAuthorId = 1,
                            BooksBookId = 5
                        },
                        new
                        {
                            AuthorsAuthorId = 2,
                            BooksBookId = 5
                        },
                        new
                        {
                            AuthorsAuthorId = 2,
                            BooksBookId = 6
                        },
                        new
                        {
                            AuthorsAuthorId = 2,
                            BooksBookId = 7
                        },
                        new
                        {
                            AuthorsAuthorId = 3,
                            BooksBookId = 8
                        },
                        new
                        {
                            AuthorsAuthorId = 4,
                            BooksBookId = 9
                        },
                        new
                        {
                            AuthorsAuthorId = 5,
                            BooksBookId = 10
                        },
                        new
                        {
                            AuthorsAuthorId = 4,
                            BooksBookId = 11
                        },
                        new
                        {
                            AuthorsAuthorId = 6,
                            BooksBookId = 12
                        },
                        new
                        {
                            AuthorsAuthorId = 6,
                            BooksBookId = 13
                        },
                        new
                        {
                            AuthorsAuthorId = 6,
                            BooksBookId = 14
                        },
                        new
                        {
                            AuthorsAuthorId = 4,
                            BooksBookId = 8
                        },
                        new
                        {
                            AuthorsAuthorId = 4,
                            BooksBookId = 10
                        },
                        new
                        {
                            AuthorsAuthorId = 5,
                            BooksBookId = 12
                        });
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.HasKey("BooksBookId", "CategoriesCategoryId");

                    b.HasIndex("CategoriesCategoryId");

                    b.ToTable("BookCategory", (string)null);

                    b.HasData(
                        new
                        {
                            BooksBookId = 1,
                            CategoriesCategoryId = 1
                        },
                        new
                        {
                            BooksBookId = 1,
                            CategoriesCategoryId = 3
                        },
                        new
                        {
                            BooksBookId = 2,
                            CategoriesCategoryId = 1
                        },
                        new
                        {
                            BooksBookId = 3,
                            CategoriesCategoryId = 3
                        },
                        new
                        {
                            BooksBookId = 4,
                            CategoriesCategoryId = 1
                        },
                        new
                        {
                            BooksBookId = 4,
                            CategoriesCategoryId = 2
                        },
                        new
                        {
                            BooksBookId = 5,
                            CategoriesCategoryId = 3
                        },
                        new
                        {
                            BooksBookId = 6,
                            CategoriesCategoryId = 3
                        },
                        new
                        {
                            BooksBookId = 7,
                            CategoriesCategoryId = 3
                        });
                });

            modelBuilder.Entity("Paskaita_8_ManyToMany.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors", (string)null);

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Jane",
                            LastName = "Smith"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "N.K.",
                            LastName = "Jemisin"
                        },
                        new
                        {
                            AuthorId = 4,
                            FirstName = "Brandon",
                            LastName = "Sanderson"
                        },
                        new
                        {
                            AuthorId = 5,
                            FirstName = "Patrick",
                            LastName = "Rothfuss"
                        },
                        new
                        {
                            AuthorId = 6,
                            FirstName = "Joe",
                            LastName = "Abercrombie"
                        });
                });

            modelBuilder.Entity("Paskaita_8_ManyToMany.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BookName");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("BookYear");

                    b.HasKey("BookId");

                    b.ToTable("Books", (string)null);

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Name = "Hobbit",
                            Year = 1937
                        },
                        new
                        {
                            BookId = 2,
                            Name = "Lord of the Rings",
                            Year = 1954
                        },
                        new
                        {
                            BookId = 3,
                            Name = "Silmarillion",
                            Year = 1977
                        },
                        new
                        {
                            BookId = 4,
                            Name = "Hitchhiker's Guide to the Galaxy",
                            Year = 1979
                        },
                        new
                        {
                            BookId = 5,
                            Name = "Dune",
                            Year = 1965
                        },
                        new
                        {
                            BookId = 6,
                            Name = "Dune: House Atreides",
                            Year = 1999
                        },
                        new
                        {
                            BookId = 7,
                            Name = "Dune: The Butlerian Jihad",
                            Year = 2002
                        },
                        new
                        {
                            BookId = 8,
                            Name = "The Fifth Season",
                            Year = 2015
                        },
                        new
                        {
                            BookId = 9,
                            Name = "Mistborn: The Final Empire",
                            Year = 2006
                        },
                        new
                        {
                            BookId = 10,
                            Name = "The Name of the Wind",
                            Year = 2007
                        },
                        new
                        {
                            BookId = 11,
                            Name = "The Way of Kings",
                            Year = 2010
                        },
                        new
                        {
                            BookId = 12,
                            Name = "Red Sister",
                            Year = 2017
                        },
                        new
                        {
                            BookId = 13,
                            Name = "The Blade Itself",
                            Year = 2009
                        },
                        new
                        {
                            BookId = 14,
                            Name = "The Heroes",
                            Year = 2011
                        });
                });

            modelBuilder.Entity("Paskaita_8_ManyToMany.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("Paskaita_8_ManyToMany.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Paskaita_8_ManyToMany.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.HasOne("Paskaita_8_ManyToMany.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Paskaita_8_ManyToMany.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
