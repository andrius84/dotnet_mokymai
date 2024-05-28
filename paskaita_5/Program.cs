using System.Diagnostics.CodeAnalysis;

namespace paskaita_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1.Uzduotis
            //string skaicius = "";
            //double suma = 0;
            //while (!(skaicius == "baigti"))
            //{
            //    Console.WriteLine("Iveskite skaicius:");
            //    skaicius = Console.ReadLine();
            //    double.TryParse(skaicius, out double skaiciusint);
            //    suma = suma + skaiciusint; 
            //    Console.WriteLine(suma);
            //}
            //Console.WriteLine($"galutine suma:" + suma);

            // 2.Uzduotis
            //string slaptazodis = "";
            //while (!(slaptazodis == "test123"))
            //{
            //    Console.WriteLine("Iveskite slaptazodi:");
            //    slaptazodis = Console.ReadLine();
            //    if (!(slaptazodis == "test123"))
            //    {
            //        Console.WriteLine("SLAPTAZODIS NETEISINGAS");
            //    }
            //}
            //Console.WriteLine("********slaptazodis teisingas********");

            // 3.Uzduotis
            
            string password = "";
            string email = "";
            
            Console.WriteLine("Iveskite slaptazodi:");
            password = Console.ReadLine();
            Console.WriteLine(IsPasswordValid(password));

            Console.WriteLine("Iveskite email:");
            email = Console.ReadLine();
            Console.WriteLine(IsEmailValid(email));

            Console.WriteLine("Iveskite suma doleriais:");
            string dollars = Console.ReadLine();
            double.TryParse(dollars, out double dollarsdouble);
            Console.WriteLine($"Turite " + ConvertToEuros(dollarsdouble) + " eurus");

        }
        public static bool IsPasswordValid(string password)
        {
            if (password.Length > 8)
            {
                return true;
            }
            else return false;
        }

        public static bool IsEmailValid(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            else return false;
        }

        public static double ConvertToEuros(double dollars)
        {   
            double euro = dollars * 0.85;
            return euro;
        }
    }
}
