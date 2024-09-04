

namespace Paskaita_5_data_seed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, DataSeed!");
            //var books = CsvHelperService.GetBooks();
            //Console.WriteLine("------------------");
            //Console.WriteLine("Books from CSV");
            //foreach (var book in books)
            //{
            //    Console.WriteLine($"BookId:{book.BookId} Title:{book.Title} Year:{book.Year}");
            //}

            //var authors = CsvHelperService.GetAuthors();
            //Console.WriteLine("------------------");
            //Console.WriteLine("Authors from CSV");
            //foreach (var author in authors)
            //{
            //    Console.WriteLine($"AuthorId:{author.AuthorId} FullName:{author.FullName} BookId:{author.BookId}");
            //}

            //var countries = CsvHelperService.GetCountries();
            //Console.WriteLine("------------------");
            //Console.WriteLine("Countries from CSV");
            //foreach (var country in countries)
            //{
            //    Console.WriteLine($"CountryId:{country.CountryId} Name:{country.Name}");
            //}

            //var genres = CsvHelperService.GetGenres();
            //Console.WriteLine("------------------");
            //Console.WriteLine("Genres from CSV");
            //foreach (var genre in genres)
            //{
            //    Console.WriteLine($"GenreId:{genre.GenreId} Name:{genre.Name}");
            //}

            //var publishers = CsvHelperService.GetPublishers();
            //Console.WriteLine("------------------");
            //Console.WriteLine("Publishers from CSV");
            //foreach (var publisher in publishers)
            //{
            //    Console.WriteLine($"PublisherId:{publisher.PublisherId} Name:{publisher.Name}");
            //}

            using var context = new BookContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Console.WriteLine("Database created");

            //var books = context.Books.ToList();
            //Console.WriteLine("------------------");
            //Console.WriteLine("Books from Database");
            //foreach (var book in books)
            //{
            //    Console.WriteLine($"BookId:{book.BookId} Title:{book.Title} Year:{book.Year}");
            //}


        }
    }
}
