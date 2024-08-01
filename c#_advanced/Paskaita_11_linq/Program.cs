using System.Reflection.Metadata;
using System;

namespace Paskaita_11_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Sukurkite sąrašą, kuriame yra visi sveikieji skaičiai nuo 1 iki 10 ir naudodami Linq metodą Where išfiltruokite visus nelyginius skaičius, bei atspausdinkite juos konsolėje

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var filteredNumbers = numbers.Where(n => n % 2 != 0);
            //foreach (var number in filteredNumbers)
            //{
            //    Console.WriteLine(number);
            //}


            //2.
            //Sukurkite bent 5 objektų sąrašą AllIphones.
            //Iš šio sąrašo sukurkite kitą sąrašą ProIPhonesWithDiscount.
            //Jame turėtų būti telefonai iš AllIphones, kurių pavadinime yra "pro".
            //Prie pavadinimo pabaigoje reiktų pridėti "(sale)", o naujoji kaina - 10 proc.mažesnė.

            //List<Phone> AllIphones = new List<Phone>()
            //{
            //    new Phone("Iphone 11", 1000),
            //    new Phone("IphonePro 12", 1200),
            //    new Phone("Iphone 13", 1300),
            //    new Phone("IphonePro 14", 1400),
            //    new Phone("Iphone 15", 1500)
            //};

            //var ProIPhonesWithDiscount = AllIphones.Where(p => p.Name.Contains("Pro"))
            //                                      .Select(p => new Phone(p.Name + "(sale)", p.Price * 0.9));




            //3. Turite Shopper objektų sąrašą, kur kiekvienas objektas turi pirkėjo vardą, adresą ir sąrašą su išleistų pinigų sumomis.Jūsų užduotis yra naudoti LINQ, kad surūšiuotumėte šį sąrašą pagal bendrą išleistų pinigų sumą, pradedant nuo didžiausios sumos.
            //Rezultatai: Max, Ali, Bob, Ron

            //    var shoppers = new List<Shopper>
            //{
            //    new Shopper { Name = "Ali", Purchases = new List<int> { 100, 25, 130 }, Address = "123 Main St" },
            //    new Shopper { Name = "Bob", Purchases = new List<int> { 50, 150 }, Address = "456 Elm St" },
            //    new Shopper { Name = "Ron", Purchases = new List<int> { 10 }, Address = "789 Oak St" },
            //    new Shopper { Name = "Max", Purchases = new List<int> { 400, 10 }, Address = "123 Main St" }
            //};

            //    var sortedShoppers = shoppers.OrderByDescending(s => s.Purchases.Sum());
            //    foreach (var shopper in sortedShoppers)
            //    {
            //        Console.Write(shopper.Name);
            //        if (shopper != sortedShoppers.Last())
            //        {
            //            Console.Write(", ");
            //        }
            //    }




                // Sukuriamas vaisių sąrašas
                List<Fruit> fruits = new List<Fruit>
            {
                new Fruit { Name = "Apple", Price = 2.5m },
                new Fruit { Name = "Banana", Price = 1.2m },
                new Fruit { Name = "Cherry", Price = 5.0m },
                new Fruit { Name = "Date", Price = 3.5m },
                new Fruit { Name = "Fig", Price = 4.0m },
                new Fruit { Name = "Grape", Price = 3.0m },
                new Fruit { Name = "Kiwi", Price = 2.8m },
                new Fruit { Name = "Lemon", Price = 1.5m },
                new Fruit { Name = "Mango", Price = 6.0m },
                new Fruit { Name = "Orange", Price = 2.0m }
            };

                // Naudojame FirstOrDefault, kad rastume pirmą vaisių su kaina didesne nei 3
                var firstExpensiveFruit = fruits
                                            .Where(f => f.Price > 3)
                                            .FirstOrDefault();

                // Naudojame Select, kad transformuotume vaisiaus informaciją, jei vaisius buvo rastas
                var result = fruits
                            .Where(f => f.Price > 3)
                            .Select(f => $"Fruit: {f.Name}, Price: {f.Price:C}")
                            .ToList();

                // Atspausdiname rezultatus
                Console.WriteLine("Result:");
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }


    public class Fruit
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Shopper
        {
            public string Name { get; set; }
            public List<int> Purchases { get; set; }
            public string Address { get; set; }
        }


        public class Phone
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Phone(string name, double price)
            {
                Name = name;
                Price = price;
            }
        }
    }

