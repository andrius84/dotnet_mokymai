using System.Globalization;

namespace paskaita_12_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 DALIS //////////////////////////
            //int[] numbers = new int[3];
            //Console.WriteLine("Enter three numbers");
            //for (int i = 0; i < 3; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //numbers = ArraySum(numbers);
            //numbers = ArrayMaxNumber(numbers);
            //Console.WriteLine($"Answer are: {numbers[0]}");

            //numbers = ArraySquare(numbers);
            //numbers = ArrayReverse(numbers);
            //Console.WriteLine($"Answer are: {numbers[0]},{numbers[1]},{numbers[2]}");

            // 2 DALIS //////////////////////////

            //StringWordToChar("Hello");
            //Console.WriteLine(StringFirstLetter("Hello World"));
            //Console.WriteLine(StringLastLetter("Hello World"));
            //AddElementToCharArray();
            //RemoveElementFromCharArray();
            //ListElementFromSmallestToLargest();
            ListElementFromLargestToSmallest();
        }

        public static char[] StringWordToChar(string word)
        {
            char[] charArray = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                charArray[i] = word[i];
            }
            return charArray;
        }

        public static char[] StringFirstLetter(string sentence)
        {
            char[] charArray = new char[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i == 0 )
                {
                    charArray[i] = sentence[i];
                }
            }
            return charArray;
        }

        public static char[] StringLastLetter(string sentence)
        {
            char[] charArray = new char[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i == sentence.Length - 1)
                {
                    charArray[i] = sentence[i];
                }
            }
            return charArray;
        }

        public static void AddElementToCharArray()
        {
            int[] Array = { 1, 2, 3 };
            int[] newArray = new int[Array.Length + 1];

            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i] = Array[i];
            }
            newArray[newArray.Length - 1] = 4;
        }

        public static void RemoveElementFromCharArray()
        {
            int[] Array = { 1, 2, 3 };
            int[] newArray = new int[Array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Array[i];
            }
        }




        public static void ListElementFromSmallestToLargest()
        {
            int[] array = { 10, 1, 5, 4, 2 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void ListElementFromLargestToSmallest()
        {
            int[] array = { 10, 1, 5, 4, 2 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }











        public static int[] ArraySquare(int[] numbers)
        {
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            
            return numbers;
        }
        public static int[] ArraySum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += numbers[i];
            }
            return new int[] { sum };
        }
        public static int[] ArrayMaxNumber(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < 3; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return new int[] { max };
        }
        public static int[] ArrayReverse(int[] numbers)
        {
            int[] reversedNumbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                reversedNumbers[i] = numbers[numbers.Length - 1 - i];
            }
            return reversedNumbers;
        }
    }
}
