namespace paskaita_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Iveskite skaiciu:");
            string skaicius = Console.ReadLine();
            int a = int.Parse(skaicius);
            Console.WriteLine(Skaicius(a));

            int mypass = 11110000;
            Console.Write("Iveskite slaptazodi:");
            string slaptazodis = Console.ReadLine();
            Console.WriteLine(Slaptazodis(slaptazodis, mypass));
        }
        public static string Skaicius(int a)
        {
            if (a > 100)
            {
                return "skaicius didesnis uz 100";
            }
            else return "skaicius mazesnis uz 100";
 
        }
        public static string Slaptazodis(string slaptazodis, int mypass)
        {
            bool raides = slaptazodis.Any(char.IsLetter);
            int b = int.Parse(slaptazodis);
            if (b == mypass && !raides)
            {
                return "Slaptazodis teisingas";
            }
            else return "Slaptazodis neteisingas";
            
        
        }
            
    }
}

