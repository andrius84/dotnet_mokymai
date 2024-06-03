using System.Xml.Serialization;

namespace paskaita_9_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello For looping");
            // PaprastasFor();
            // DekrementasFor();
            // ForDisplayEvenNumber();
            // ForFrom1To15();
            // PrintNumbersDescending();
            // Console.WriteLine("Even numbers count: " + CountEvenNumbersWithError());
            // PrintFibonacciWithError();
            // PrintSquaresWithError();
            // Console.WriteLine(SumEvenNumbersWithError());
            // PrintPricesFromOneToTen();
            // PrintCoffeMachinesfromOneToFivewithPrices();
            // PrintTableReservationFromOneToEight();
            // PrintGymMachinesCheckedFromOneToTen();

        }
        static void PaprastasFor()
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void DekrementasFor()
        {
            for (int i = 20; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void ForDisplayEvenNumber()
        {
            for (int i = 20; i >= 0; i -= 3)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void ForFrom1To15()
        {
            for (int i = 1; i <= 15; i++)
            {
                if (i == 12) break;
                Console.WriteLine(i);
            }
        }
        public static void PrintNumbersDescending()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static int CountEvenNumbersWithError()
        {
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static void PrintFibonacciWithError()
        {
            int a = 0, b = 1, c;
            Console.WriteLine(a);
            for (int i = 1; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(b);
                a = b;
                b = c;
            }
        }
        public static void PrintSquaresWithError()
        {
            for (int i = 1; i <= 10; i++)
            {
                int square = i * i;
                Console.WriteLine("Skaičius: " + i + ", Kvadratas: " + square);
            }
        }
        public static int SumEvenNumbersWithError()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static void PrintPricesFromOneToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Price : {i} $");
            }
        }
        public static void PrintCoffeMachinesfromOneToFivewithPrices()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Coffee Machine {i} checked");
            }
        }
        public static void PrintTableReservationFromOneToEight()
        {
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine($"Table {i} reserved");
            }
        }
        public static void PrintGymMachinesCheckedFromOneToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Gym Machine {i} checked");
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Gym Machine {i} is clean");
                }
            }
        }
    }
}
