using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_1_OOP_class_constructor
{
    internal class Book
    {
        public Book(List<Book> books, string author)
        {
            FindBookOfAuthor(books, author);
        }
        public Book(string title, string author, int years, string countryOfPublication)
        {
            Title = title;
            Author = author;
            Years = years;
            CountryOfPublication = countryOfPublication;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Years { get; set; }
        public string CountryOfPublication { get; set; }
    
        public List<Book> FindBookOfAuthor(List<Book> books, string author)
        {
            foreach (var book in books)
            {
                if (book.Author == author) books.Add(book);
            }
            return books;
        }
    }
    
}
