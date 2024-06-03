namespace paskaita_8_ref_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine("1. Uzduotis");
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before swap a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After swap a = {a}, b = {b}");

            // 2.
            Console.WriteLine("2. Uzduotis");
            int n = 10;
            Console.WriteLine($"Before increment a = {a}");
            IncrementByN(ref a, n);
            Console.WriteLine($"After increment a = {a}");

            // 3.
            Console.WriteLine("3. Uzduotis");
            string text = " codeacademy ";
            Console.WriteLine($"Before trim and capitalize text = {text}");
            TrimAndCapitalize(ref text);
            Console.WriteLine($"After trim and capitalize text = {text}");

            // 4.
            Console.WriteLine("4. Uzduotis");
            GetUserData(out string firstname, out string lastname);
            Console.WriteLine($"Hello, {firstname} {lastname}");

            // 5.
            Console.WriteLine("5. Uzduotis");
            int number = 0;
            while (number <= 100)
            {
                Console.WriteLine("Enter number:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if (number > 100)
                    {
                        Console.WriteLine("Number is greater than 100");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Number is less than 100");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            // 6.
            Console.WriteLine("6. Uzduotis");
            Console.WriteLine("Iveskite skaiciu:");
            string skaicius = Console.ReadLine();
            double.TryParse(skaicius, out double numbersk);
            Console.WriteLine("Iveskite dalmeni:");
            string skaicius2 = Console.ReadLine();
            double.TryParse(skaicius2, out double mod);
            Console.WriteLine(Divide(numbersk, ref mod, out double result));
            Console.WriteLine(result);
            Console.WriteLine(mod);

        }
        public static int Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return 0;
        }
        public static int IncrementByN(ref int a, int n)
        {
            a += n;
            return a;
        }
        public static string TrimAndCapitalize(ref string text)
        {
            text = text.Trim();
            text = char.ToUpper(text[0]) + text.Substring(1);
            return text;
        }
        public static void GetUserData(out string firstname, out string lastname)
        {
            Console.WriteLine("Enter your name:");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            lastname = Console.ReadLine();
        }
        public static bool Divide(double numbersk, ref double mod, out double result)

        {
            if (mod == 0)
            {
                result = 0;
                return false;
            }
            else
            {
                result = numbersk / mod;
                mod = numbersk % mod;
                return true;
            }
        }
    }
}
