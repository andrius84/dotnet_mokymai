using System.Diagnostics.CodeAnalysis;

namespace paskaita_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Uzduotis
            string skaicius = "";
            double suma = 0;
            do
            {
                Console.WriteLine("Iveskite skaicius:");
                skaicius = Console.ReadLine();
                skaicius = skaicius.ToLower();
                double.TryParse(skaicius, out double skaiciusint);
                suma = suma + skaiciusint;
                Console.WriteLine(suma);
            } while (!(skaicius == "baigti"));
            Console.WriteLine($"galutine suma:" + suma);

            // 2.Uzduotis
            //string slaptazodis = "";
            //do
            //{
            //    Console.WriteLine("Iveskite slaptazodi:"); 
            //    slaptazodis = Console.ReadLine();
            //    if (!(slaptazodis == "test123"))
            //    {
            //        Console.WriteLine("SLAPTAZODIS NETEISINGAS");
            //    }
            //} while (!(slaptazodis == "test123")) ;
            //    Console.WriteLine("********slaptazodis teisingas********");

            // 3.Uzduotis

            //string password = "";
            //Console.WriteLine("Iveskite slaptazodi:");
            //password = Console.ReadLine();
            //Console.WriteLine(IsPasswordValid(password));

            //string email = "";
            //Console.WriteLine("Iveskite email:");
            //email = Console.ReadLine();
            //Console.WriteLine(IsEmailValid(email));

            //Console.WriteLine("Iveskite suma doleriais:");
            //string dollars = Console.ReadLine();
            //double.TryParse(dollars, out double dollarsdouble);
            //Console.WriteLine($"Turite " + ConvertToEuros(dollarsdouble) + " eurus");

            // 4.Uzduotis

            //Console.WriteLine("Iveskite varda:");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Iveskite pavarde:");
            //string lastName = Console.ReadLine();
            //Console.WriteLine(GetInitials(firstName, lastName));

            //Console.WriteLine("Enter radius:");
            //string sradius = Console.ReadLine();
            //double.TryParse(sradius, out double radius);
            //Console.WriteLine("Enter height:");
            //string sheight = Console.ReadLine();
            //double.TryParse(sheight, out double height);
            //Console.WriteLine($"Volume:" + CalculateCylinderVolume(radius, height));

            //Console.WriteLine("Enter number:");
            //string snumber = Console.ReadLine();
            //int.TryParse(snumber, out int number);
            //Console.WriteLine(IsNumberEven(number));
            //if(IsNumberEven(number))
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            //Console.WriteLine("Enter lenght:");
            //string slenght = Console.ReadLine();
            //double.TryParse(slenght, out double lenght);
            //Console.WriteLine("Enter width:");
            //string swidth = Console.ReadLine();
            //double.TryParse(swidth, out double width);
            //Console.WriteLine($"Area:" + CalculateRectangleArea(lenght, width));

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

        public static string GetInitials (string fistName,string lastName)
        {
            return fistName + " " + lastName;
        }

        public static double CalculateCylinderVolume (double radius, double height)
        {
            double turis = Math.PI * Math.Pow(radius, 2) * height;
            return turis;
        }

        public static bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public static double CalculateRectangleArea(double lenght, double width)
        {
            double plotas = lenght * width;
            return plotas;
        }

        
    }
}
