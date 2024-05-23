namespace paskaita_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Iveskite skaiciu:");
            string skaicius = Console.ReadLine();
            int a = int.Parse(skaicius);
            if (a > 100)
            {
                Console.WriteLine("skaicius didesnis uz 100");
            }
            else
            {
                Console.WriteLine("skaicius mazesnis uz 100");
            }

            int mypass = 11110000;
            Console.Write("Iveskite slaptazodi:");
            string slaptazodis = Console.ReadLine();
            int b = int.Parse(slaptazodis);
            bool raides = slaptazodis.Any(char.IsLetter);      
            if (raides)
            {
                Console.WriteLine("Slaptazodis neteisingas.");
            }
            else
            {
                if (b == mypass)
                {
                    Console.WriteLine("Slaptazodis neteisingas");
                }
                else 
                { 
                    Console.WriteLine("Slaptazodis neteisingas"); 
                }
                
            }
        }
    }
}
