using System;

namespace paskaita_15_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RandomExample();
            //RandomBool();
            //RandomAZLetter();
            //RandomNumberFrom1to6();
            //RandomNumberFrom1to100();

            //int[,] multiarray = GenerateMultiArrayFrom1to8();
            //CountEvenOddInMultiArray(multiarray);


        }

        static void RandomExample()
        {
            Random random = new Random();
            int randomNumber = 0;
            for (int i = 0; i < 10; i++)
            {
                randomNumber = random.Next(1, 10);
                Console.WriteLine(randomNumber);
            }
        }
        static void RandomBool()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                bool randomBool = random.Next(0, 2) == 0;
                Console.WriteLine(randomBool);
            }
        }
        static void RandomAZLetter()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                char randomChar = (char)random.Next('A', 'Z');
                Console.Write(randomChar);
            }
        }
        static void RandomNumberFrom1to6()
        {
            Random random = new Random();
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                int randomNumber = random.Next(1, 7);
                sum = sum + randomNumber;
                Console.WriteLine(randomNumber);
            }
            Console.WriteLine("Suma: " + sum);
        }
        static void RandomNumberFrom1to100()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine("Spekite ar sugeneruotas skaicius bus didesnis 50 taip/ne: ");
            string guess = Console.ReadLine();
            if (guess == "taip" && randomNumber < 50)
            {
                Console.WriteLine("Spejamas skaicius per mazas: " + randomNumber);
            }
            else if (guess == "ne" && randomNumber >= 50)
            {
                Console.WriteLine("Spejamas skaicius per didelis: " + randomNumber);
            }
            else
            {
                Console.WriteLine("Atspejote: " + randomNumber);
            }
        }
        public static int[,] GenerateMultiArrayFrom1to8()
        {
            int[,] multiarray = new int[8, 8];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    multiarray[i, j] = random.Next(1, 80);
                    Console.Write(multiarray[i, j] + "  ");
                }
                Console.WriteLine();
            }
            return multiarray;
        }
        static void CountEvenOddInMultiArray(int[,] multiarray)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (multiarray[i, j] % 2 == 0)
                    {
                        
                    }
                }
                Console.WriteLine();
            }



        }
    }
}
