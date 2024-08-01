using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_2_class_methods
{
    public class NumbersList
    {
        public NumbersList()
        {
            numbers = new List<int>();
        }
        public List<int> numbers { get; set; }
        public void AddNumber(int number)
        {
            numbers.Add(number);
        }
        public void PrintList() 
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
