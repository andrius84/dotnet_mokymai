namespace paskaita_2
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

            Console.WriteLine("Iveskite slaptazodi:");
            int b = int.Parse(Console.ReadLine());
            var mypass = "mellon";

             




        }
    }
}
