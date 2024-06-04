using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Text;
using System.Transactions;

namespace paskaita_10_debug_string_builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  ForCycleRepeat();

            //int a = 10;
            //int b = 5;
            //int c = 8;
            //int max = a;
            //if (b > max)
            //{
            //    max = b;
            //}
            //if (c > max)
            //{
            //    max = c;
            //}
            //Console.WriteLine("Max = {0} ", max);

            //string firstName = "John";
            //string lastName = "Doe";
            //string fullName = firstName + " " + lastName;
            //Console.WriteLine("Full Name: " + fullName);

            //int counter = 1;
            //while (counter <= 10)
            //{
            //    Console.WriteLine("Count = " + counter);
            //    counter++;
            //}

            //int i = 1;
            //while (i < 6)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Console.WriteLine("Enter text:");
            //string text = Console.ReadLine();
            //StringBuilder sb = new StringBuilder();
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    sb.Append(text[i]);
            //}
            //Console.Write("Reverse text: ");
            //Console.WriteLine(sb.ToString());

            //    Console.WriteLine("Enter text line: ");
            //    string text = Console.ReadLine();
            //    StringBuilder sb = new StringBuilder();
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (sb.ToString().IndexOf(text[i]) == -1)
            //        {
            //            sb.Append(text[i]);
            //        }
            //    }
            //    Console.WriteLine("Text without dublicate letters:");
            //    Console.WriteLine(sb.ToString());

            Console.WriteLine("Enter 3 fiels: ");
            Console.WriteLine("Field 1: ");
            string field1 = Console.ReadLine();
            Console.WriteLine("Field 2: ");
            string field2 = Console.ReadLine();
            Console.WriteLine("Field 3: ");
            string field3 = Console.ReadLine();
            string csvLine = CreateCsvLine(field1, field2, field3);
            Console.WriteLine($"Csv line: {csvLine} ");

        }
        public static StringBuilder sbulder = new StringBuilder();

        public static string CreateCsvLine(string field1, string field2, string field3)
        {
            if (string.IsNullOrEmpty(field1) || field1.Contains(",") || field1.Length > 10)
            {
                throw new ArgumentException("Field 1 is empty, contains a comma, or exceeds the maximum length.");
            }
            if (string.IsNullOrEmpty(field2) || field2.Contains(",") || field2.Length > 11)
            {
                throw new ArgumentException("Field 2 is empty, contains a comma, or exceeds the maximum length.");
            }
            if (field3.Contains(",") || field3.Length > 9)
            {
                throw new ArgumentException("Field 3 contains a comma or exceeds the maximum length.");
            }
            if (sbulder.Length > 0)
            {
                sbulder.Append("\n");
            }
            sbulder.Append("\"");
            sbulder.Append(field1);
            sbulder.Append("\",\"");
            sbulder.Append(field2);
            sbulder.Append("\",\"");
            sbulder.Append(field3);
            sbulder.Append("\"");
            return sbulder.ToString();
        }

        static void ForCycleRepeat()
        {
            int sum = 0;
            int count = 0;

            for (int i = 100; i < 400; i += 3)
            {
                sum = sum + i;
                count++;
            }
            Console.WriteLine("Sum = {0} ", sum);
            Console.WriteLine($"Count = {count} ");
        }
    }
}
