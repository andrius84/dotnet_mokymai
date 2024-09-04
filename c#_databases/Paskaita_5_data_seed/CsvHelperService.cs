using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paskaita_5_data_seed.Entities;

namespace Paskaita_5_data_seed
{
    public static class CsvHelperService
    {
        public static List<Book> GetBooks()
        {
            var csv = File.ReadAllLines("../../../InitialData/Books.csv");
            var books = new List<Book>();
            foreach (var line in csv)
            {
                var values = line.Split(',');
                var book = new Book
                {
                    BookId = int.Parse(values[0]),
                    Title = values[1],
                    Year = int.Parse(values[2]),
                    GenreId = int.Parse(values[3]),
                    PublisherId = int.Parse(values[4])
                };
                books.Add(book);
            }
            return books;
        }
        public static List<Author> GetAuthors()
        {
            var csv = File.ReadAllLines("../../../InitialData/Authors.csv");
            var authors = new List<Author>();
            foreach (var line in csv)
            {
                var values = line.Split(',');
                var author = new Author
                {
                    AuthorId = int.Parse(values[0]),
                    FullName = values[1],
                    BookId = int.Parse(values[2]),
                    CountryId = int.Parse(values[3])
                };
                authors.Add(author);
            }
            return authors;
        }
        public static List<Country> GetCountries()
        {
            var csv = File.ReadAllLines("../../../InitialData/Countries.csv");
            var countries = new List<Country>();
            foreach (var line in csv)
            {
                var values = line.Split(',');
                var country = new Country
                {
                    CountryId = int.Parse
                    (values[0]),
                    Name = values[1]
                };
                countries.Add(country);
            }
            return countries;
        }
        public static List<Genre> GetGenres()
        {
            var csv = File.ReadAllLines("../../../InitialData/Genres.csv");
            var genres = new List<Genre>();
            foreach (var line in csv)
            {
                var values = line.Split(',');
                var genre = new Genre
                {
                    GenreId = int.Parse(values[0]),
                    Name = values[1]
                };
                genres.Add(genre);
            }
            return genres;
        }
        public static List<Publisher> GetPublishers()
        {
            var csv = File.ReadAllLines("../../../InitialData/Publishers.csv");
            var publishers = new List<Publisher>();
            foreach (var line in csv)
            {
                var values = line.Split(',');
                var publisher = new Publisher
                {
                    PublisherId = int.Parse(values[0]),
                    Name = values[1]
                };
                publishers.Add(publisher);
            }
            return publishers;
        }
    }
}
