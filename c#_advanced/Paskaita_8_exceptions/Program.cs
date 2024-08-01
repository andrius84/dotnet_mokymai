namespace Paskaita_8_exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("Uzduotis 1");
            Class1 class1 = new Class1();
            class1.GetAllExceptions("a");
            class1.GetAllExceptions("1.79769313486232E+30933333");
            Console.WriteLine("Pabaiga");

            //2.
            Console.WriteLine("Uzduotis 2");
            GFG test = new GFG();
            test.Method2WithTryCatch();
            Console.WriteLine("Pabaiga");

            //3.
            Console.WriteLine("Uzduotis 3");
            test.Method3WithTryCatch();
            Console.WriteLine("Pabaiga");

            //4.
            Console.WriteLine("Uzduotis 4");
            Files files = new Files();
            files.ReadFile();
            Console.WriteLine("Pabaiga");























        }
    }
}
