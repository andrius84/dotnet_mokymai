using System.Security.Permissions;

namespace paskaita_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            Console.WriteLine("Choose number what you want to do:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Number by degree");
            Console.WriteLine("Exit press q");
            string option = Console.ReadLine();
            if (option == "q")
            {
                return;
            }
            Console.WriteLine("Enter first number:");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            number2 = Convert.ToDouble(Console.ReadLine());
            switch (option[0])
            {
                case '1':
                    Console.WriteLine(Sum(number1, number2));
                    break;
                case '2':
                    Console.WriteLine(Subtract(number1, number2));
                    break;
                case '3':
                    Console.WriteLine(Multiply(number1, number2));
                    break;
                case '4':
                    Console.WriteLine(Divide(number1, number2));
                    break;
                case '5':
                    Console.WriteLine(NumberByDegree(number1, number2));
                    break;
                case 'q':
                    Console.WriteLine("Exit");
                    break;
            }
        }
        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
        public static double NumberByDegree(double number1, double number2)
        {
            return Math.Pow(number1,number2);
        }
    }
}
