namespace Paskaita_1_OOP_class_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            //Person person = new Person("Jonas", 25);
            //Person person2 = new Person(180);
            //School school = new School("CodeAcademy", "Vilnius", 10);
            //Console.WriteLine($"Vardas: {person.Name}");
            //Console.WriteLine($"Amzius: {person.Age}");    
            //Console.WriteLine($"Ugis: {person2.Height}");
            //Console.WriteLine($"Mokykla: {school.Name}");
            //Console.WriteLine($"Miestas: {school.City}");
            //Console.WriteLine($"Mokiniu skaicius: {school.numberOfStudents}");

            // 2.
            Book book = new Book("Grazi", "Nezinomas", 2020, "Lietuva");
            Console.WriteLine($"Knyga: {book.Title}, {book.Author}, {book.Years}, {book.CountryOfPublication}");

            List<Book> books = new List<Book>
            {
                new Book("knyga1", "Nezinomas1", 2020, "Lietuva"),
                new Book("knyga2", "Nezinomas2", 2020, "Lietuva"),
                new Book("knyga3", "Nezinomas3", 2020, "Lietuva"),
                new Book("knyga4", "Nezinomas4", 2020, "Lietuva"),
                new Book("knyga5", "Nezinomas1", 2020, "Lietuva"),
                new Book("knyga6", "Nezinomas6", 2020, "Lietuva"),
                new Book("knyga7", "Nezinomas1", 2020, "Lietuva"),
            };
            List<Book> booksOfAuthor = book.FindBookOfAuthor(books, "Nezinomas1");
            foreach (var bookOfAuthor in booksOfAuthor)
            {
                Console.WriteLine($"Knygos: {bookOfAuthor.Title}, {bookOfAuthor.Author}, {bookOfAuthor.Years}, {bookOfAuthor.CountryOfPublication}");
            }

        }
    }
}
