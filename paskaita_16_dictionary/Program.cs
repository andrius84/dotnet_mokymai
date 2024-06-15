namespace paskaita_16_dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DictionaryNamesAndAges();


            Console.WriteLine("Iveskite salies pavadinima: ");
            string salisInput = Console.ReadLine();
            CountriesAndCapitals(salisInput);


            //Dictionary<string, int> fruits = new Dictionary<string, int>
            //{
            //    { "Obuolys", 5 },
            //    { "Kriause", 10 },
            //    { "Slyva", 15 }
            //};
            //PrintDictionary(fruits);
            //Console.WriteLine("Iveskite vaisiaus pavadinima ir kieki: ");
            //string fruit = Console.ReadLine();
            //int.TryParse(Console.ReadLine(), out int amount);
            //DictionaryOfFruits(fruits, fruit, amount);
            //PrintDictionary(fruits);


            //StudentsGrades();


            //MonthsAndDays();

        }

        static void DictionaryNamesAndAges()
        {
            Dictionary<string, int> namesAndAges = new Dictionary<string, int>
            {
                { "Jonas", 25 },
                { "Petras", 30 },
                { "Antanas", 35 }
            };
            foreach (var name in namesAndAges)
            {
                Console.WriteLine($"Name: {name.Key}, Age: {name.Value}");
            }
        }
        public static string CountriesAndCapitals(string salisInput) 
        {
            Dictionary<string, string> countriesandcapitals = new Dictionary<string, string>
            {
                { "Lietuva", "Vilnius" },
                { "Latvija", "Ryga" },
                { "Estija", "Talinas" },
                { "Lenkija", "Varsuva" },
                { "Vokietija", "Berlynas" },
                { "Svedija", "Stokholmas" }
            };
            string salis = char.ToUpper(salisInput[0]) + salisInput.Substring(1).ToLower();
            Console.Write($"Salies {salis} ");
            string sostine = "";

                if (countriesandcapitals.ContainsKey(salis))
                {
                sostine = countriesandcapitals[salis];
                }
                else
                {
                    sostine = "nerasta";
                }
            
            Console.WriteLine($"sostine yra {sostine}");
            return sostine;
        }
        public static void PrintDictionary(Dictionary<string, int> fruits)
        {
            foreach (var item in fruits)
            {
                Console.WriteLine($"Salis: {item.Key}, Sostine: {item.Value}");
            }
        }
        public static Dictionary<string, int> DictionaryOfFruits(Dictionary<string, int> fruits, string fruit, int amount)
        {
            if (fruits.ContainsKey(fruit))
            {
                fruits[fruit] += amount; 
            }
            else
            {
                fruits.Add(fruit, amount); 
            }
            return fruits;
        }
        public static void StudentsGrades()
        {
            Dictionary<string, List<int>> studentsGrades = new Dictionary<string, List<int>>
            {
                { "Rokas", new List<int> { 5, 6, 7, 8, 9 } },
                { "Nojus", new List<int> { 4, 5, 6, 7, 8 } },
                { "Atas", new List<int> { 3, 4, 5, 6, 7 } }
            };
            Console.WriteLine("Iveskite studento varda: ");
            string studentName = Console.ReadLine();
            studentsGrades.TryGetValue(studentName, out List<int> grades);
            Console.Write($"{studentName} pazymiai: ");
            foreach (var grade in grades)
            {
                Console.Write($"{grade}, ");
            }
        }
        public static void MonthsAndDays()
        {
            Dictionary<string, int> monthsAndDays = new Dictionary<string, int>
            {
                { "Sausis", 31 },
                { "Vasaris", 28 },
                { "Kovas", 31 },
                { "Balandis", 30 },
                { "Geguze", 31 },
                { "Birzelis", 30 },
                { "Liepa", 31 },
                { "Rugpjutis", 31 },
                { "Rugsejis", 30 },
                { "Spalis", 31 },
                { "Lapkritis", 30 },
                { "Gruodis", 31 }
            };
            foreach (var month in monthsAndDays)
            {
                if (month.Value < 31)
                {
                    Console.WriteLine($"Menuo: {month.Key}, turi dienu: {month.Value}");
                }
            }
        }
    }
}
