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
            var bookCategories = new List<object>();
            var csv = File.ReadAllLines("InitialData/BooksCategories.csv");
            foreach (var line in csv) 
            {
                var values = line.Split(',');
                int bookId = int.Parse(values[0]);
                int categoryId = int.Parse(values[1]);

                bookCategories.Add(new { BooksBookId = bookId, CategoriesCategoryId = categoryId });
            }
            return bookCategories;
        }
    }
}
