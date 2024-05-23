using System;

namespace paskaita_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite figuros pavadinima:");
            string figura = Console.ReadLine().ToLower();
            switch (figura)
            {
                case "kvadratas":
                    Console.WriteLine("Iveskite kvadrato krastine");
                    string sk = Console.ReadLine();
                    int kv = int.Parse(sk);
                    int pl = kv * kv;
                    Console.WriteLine($"plotas:{pl}");
                    break;
                case "apskritimas":
                    Console.WriteLine("Iveskite apskritimo spinduli");
                    string sk5 = Console.ReadLine();
                    int ap = int.Parse(sk5);
                    double pl1 = 3.14 * ap * ap;
                    Console.WriteLine($"plotas:{pl1}");
                    break;
                case "trikampis":
                    Console.WriteLine("trikampis");

                    Console.WriteLine("plotas:");
                    break;
                case "staciakampis":
                    Console.WriteLine("staciakampis");

                    Console.WriteLine("plotas:");
                    break;
                default:
                    Console.WriteLine("Nera tokios figuros");
                    break;
            }


            Console.WriteLine("Iveskite elemento pavadinima:");
            string elementas = Console.ReadLine().ToLower();
            switch (elementas)
            {
                case "ugnis":
                    Console.WriteLine("Karsta");
                    break;
                case "vanduo":
                    Console.WriteLine("Slapias");
                    break;
                case "oras":
                    Console.WriteLine("bekvapis");
                    break;
                case "zeme":
                    Console.WriteLine("melyna");
                    break;
                case "eteris":
                    Console.WriteLine("kosmosas");
                    break;
                default:
                    Console.WriteLine("nera tokio");
                    break;
            }


            ///////////////////////////////////////////////////////////////////
            Console.Write("Iveskite savo amziu:");
            string metai = Console.ReadLine();
            int a = int.Parse(metai);
            if (a < 18)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Jums priklauso nepilnamecio akcija");
            }
            else if (a >= 18 && a < 65)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Jus esate suauges");
            }
            else if (a >= 65)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("Jums priklauso senjoro pensija");
            }
            ////////////////////////////////////////////////////////////////////
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Ar keliamieji metai, iveskite metus:");
            string m = Console.ReadLine();
            int b = int.Parse(m);
            int liek = b % 4;
            if (liek == 0)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tai yra keliamieji metai");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Tai nera keliamieji metai");
            }

            //////////////////////////////////////////////////////////////////////
            int sp;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Skaiciai \n");
            Console.Write("Iveskite pirma skaiciu:");
            string s1 = Console.ReadLine();
            int sk1 = int.Parse(s1);
            Console.Write("Iveskite antra skaiciu:");
            string s2 = Console.ReadLine();
            int sk2 = int.Parse(s2);
            Console.Write("Iveskite trecia skaiciu:");
            string s3 = Console.ReadLine();
            int sk3 = int.Parse(s3);

            if (sk1 > 0 && sk2 > 0)
            {
                sp = sk1 + sk2;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Suma:");
                Console.WriteLine(sp);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (sk2 > 0 && sk3 > 0)
            {
                sp = sk2 + sk3;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Suma:");
                Console.WriteLine(sp);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (sk1 > 0 && sk3 > 0)
            {
                sp = sk1 + sk3;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Suma:");
                Console.WriteLine(sp);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Neimanoma suskaiciuoti sumos");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
