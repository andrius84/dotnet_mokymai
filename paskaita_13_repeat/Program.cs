using System.Text;

namespace paskaita_13_repeat
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] vaisiai = { "Obuolys", "Bananai", "Braškės" };
            //Vaisiai2(vaisiai);

            //EnterAndFillMultiArray();
            //FindMultiArrayMaxValue();
        }

        public static void EnterAndFillMultiArray()
        {
            Console.WriteLine("Enter array rows and columns: ");
            string[] dimensions = Console.ReadLine().Split(' ');
            int row = int.Parse(dimensions[0]);
            int column = int.Parse(dimensions[1]);
            int[,] array = new int[row, column];
            Console.WriteLine("Enter array elements: ");
            string[] elements = Console.ReadLine().Split(',');
            int index = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = int.Parse(elements[index]);
                    index++;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sb.Append(array[i, j] + " ");
                }
                sb.AppendLine();
            }
            Console.WriteLine("Multi array you entered: ");
            Console.WriteLine(sb.ToString());
        }

        public static void FindMultiArrayMaxValue()
        {
            int[,] multiarray = new int[3, 3] 
            {
                { 1, 2, 3 }, 
                { 4, 50, 6 }, 
                { 7, 8, 9 } 
            };
            int max = multiarray[0, 0];
            int maxrow = 0;
            int maxcolumn = 0;
            for (int i = 0; i < multiarray.GetLength(0); i++)
            {
                for (int j = 0; j < multiarray.GetLength(1); j++)
                {
                    if (multiarray[i, j] > max)
                    {
                        max = multiarray[i, j];
                        maxrow = i;
                        maxcolumn = j;
                    }
                }
            }
            Console.WriteLine($"Max value in multi array is: {max}");
            Console.WriteLine($"Max value is located at row = {maxrow + 1}, column = {maxcolumn + 1}");
        }


        public static void VaisiuMasyvas(string[] vaisiai)
        {
            for (int i = 0; i < vaisiai.Length; i++)
            {
                Console.WriteLine($"{vaisiai[i]}: {vaisiai[i].Length} ");
            }
        }
        public static void VaisiuMasyvasWithStringBuilder(string[] vaisiai2)
        {
            StringBuilder sbvaisiai = new StringBuilder();
            sbvaisiai.Append(string.Join(", ", vaisiai2));
            Console.WriteLine(sbvaisiai.ToString());
            Console.Write("Viso raidziu: ");
            Console.WriteLine(sbvaisiai.Length);
        }
        public static void Vaisiai2(string[] vaisiai)
        {
            int raidziuSkaicius = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var vaisius in vaisiai)
            {
                sb.Append($"{vaisius}, {vaisius.Length}, ");
                raidziuSkaicius += vaisius.Length;
            }
            Console.WriteLine(sb.ToString().TrimEnd(',', ' '));
            Console.WriteLine($"Viso raidžių - {raidziuSkaicius}");
        }
        public static string[] VaisiaiCreateArrayWithLetterCount(string[] vaisiai)
        {
            string[] resultArray = new string[vaisiai.Length * 2];
            if (vaisiai == null)
            {
                return new string[] { };
            }
            for (int i = 0; i < vaisiai.Length; i++)
            {
                resultArray[i * 2] = vaisiai[i];
                resultArray[i * 2 + 1] = vaisiai[i].Length.ToString();
            }
            return resultArray;
        }

        public static int VaisiaiCalculateSumOfLetters(string[] vaisiai)
        {
            int raidziuSkaicius = 0;
            foreach (var vaisius in vaisiai)
            {
                raidziuSkaicius += vaisius.Length;
            }
            return raidziuSkaicius;
        }
    }
}
