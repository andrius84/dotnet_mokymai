using Paskaita_8_ManyToMany.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_8_ManyToMany
{
    public static class CsvHelperService
    {
        public static List<Book> GetBooks()
        {
            var csv = File.ReadAllLines("InitialData/Books.csv");
            var books = new List<Book>();
            foreach (var line in csv) 
            {
                var values = line.Split(',');
                var book = new Book
                {
                    BookId = int.Parse(values[0]),
                    Name = values[1],
                    Year = int.Parse(values[2])
                };
                books.Add(book);
            }
            return books;
        }
        public static List<Category> GetCategories()
        {
            var csv = File.ReadAllLines("InitialData/Categories.csv");
            var categories = new List<Category>();
            foreach (var line in csv) 
            {
                var values = line.Split(',');
                var category = new Category
                {
                    CategoryId = int.Parse(values[0]),
                    Name = values[1]
                };
                categories.Add(category);
            }
            return categories;
        }
        public static List<object> GetBooksAndCategories()
        {
            var csv = File.ReadAllLines("InitialData/BooksCategories.csv");
            var booksCategories = new List<object>();
            foreach (var line in csv) 
            {
                var values = line.Split(',');
                int bookId = int.Parse(values[0]);
                int categoryId = int.Parse(values[1]);

                booksCategories.Add(new { BooksBookId = bookId, CategoriesCategoryId = categoryId });
            }
            return booksCategories;
        }
        public static List<Author> GetAuthors()
        {
            var csv = File.ReadAllLines("InitialData/Authors.csv");
            var authors = new List<Author>();
            foreach (var line in csv)
            {
                var values = line.Split(',');
                var author = new Author
                {
                    AuthorId = int.Parse(values[0]),
                    FirstName = values[1],
                    LastName = values[2]
                };
                authors.Add(author);
            }
            return authors;
        }
        public static List<object> GetBooksAndAuthors()
        {
            var csv = File.ReadAllLines("InitialData/BooksAuthors.csv");
            var booksAuthors = new List<object>();
            foreach (var line in csv)
            {
                var values = line.Split(',');
                int bookId = int.Parse(values[0]);
                int authorId = int.Parse(values[1]);

                booksAuthors.Add(new { BooksBookId = bookId, AuthorsAuthorId = authorId });

            }
            return booksAuthors;
        }
    }
}
