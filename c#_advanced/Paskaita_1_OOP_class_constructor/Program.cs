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
            //Console.WriteLine($"Mokiniu skaicius: {school.NumberOfStudents}");

            // 2.
            //Book book = new Book("Grazi", "Nezinomas", 2020, "Lietuva");
            //Console.WriteLine($"Knyga: {book.Title}, {book.Author}, {book.Years}, {book.CountryOfPublication}");

            //Book book1 = new Book("Grazi", "Nezinomas1", 2020, "Lietuva");
            //Book book2 = new Book("Grazi2", "Nezinomas2", 2021, "Lietuva");
            //Book book3 = new Book("Grazi3", "Nezinomas3", 2022, "Lietuva");
            //List<Book> books = new List<Book> { book1, book2, book3 };

            //List<string> booksOfAuthor = new List<string>();
            //booksOfAuthor = FindBookOfAuthor(books, "Nezinomas1");
            //foreach (var bookOfAuthor in booksOfAuthor)
            //{
            //    Console.WriteLine(bookOfAuthor);
            //}

            //3.
            //Store store1 = new Store("Maxima", "2020-10-01", new List<string> { "pienas", "duona", "suris" });
            //Store store2 = new Store("Rimi", "2021-11-01", new List<string> { "pienas", "duona", "suris" });
            //Store store3 = new Store("Iki", "2022-12-01", new List<string> { "pienas", "duona", "suris" });

            //foreach (var product in store1.ProductName)
            //{
            //    Console.WriteLine($"Parduotuve: {store1.Name}, {store1.OpenDate}, {product}");
            //    Console.WriteLine($"Parduotuve: {store2.Name}, {store2.OpenDate}, {product}");
            //    Console.WriteLine($"Parduotuve: {store3.Name}, {store3.OpenDate}, {product}");
            //}

            //4.
            //Dog dog = new Dog("Rex", 5);
            //Cat cat = new Cat("Murka", 3);
            //Hamster hamster = new Hamster("Rikis", 2);
            //ReturnNamesInList(dog, cat, hamster);
            //ReturnNamesInDictionary(dog, cat, hamster);

            //5.
            //Square square = new Square(5);
            //Console.WriteLine(square.GetArea());

            //6.
            //Car car = new Car(true);
            //car.EngineRun();
            //ShowEngineStatus(car);

            //7.
            PersonNew personNew = new PersonNew();
            Address city = new Address();
            personNew.Name = "Jonas";
            personNew.Age = 25;


        }
        public static List<string> FindBookOfAuthor(List<Book> books, string author)
        {
            var booksOfAuthor = new List<string>();
            foreach (var book in books)
            {
                if (book.Author == author) booksOfAuthor.Add(author);
            }
            return booksOfAuthor;
        }
        public static List<string> ReturnNamesInList(Dog dog, Cat cat, Hamster hamster)
        {
            var names = new List<string>();
            names.Add(dog.Name);
            names.Add(cat.Name);
            names.Add(hamster.Name);
            return names;
        }
        public static Dictionary<string, int> ReturnNamesInDictionary(Dog dog, Cat cat, Hamster hamster)
        {
            var names = new Dictionary<string, int>();
            names.Add(dog.Name, dog.Age);
            names.Add(cat.Name, cat.Age);
            names.Add(hamster.Name, hamster.Age);
            return names;
        }
        public static void ShowEngineStatus(Car car)
        {
            Console.WriteLine(car.Engine.Status);
        }
    }
}
