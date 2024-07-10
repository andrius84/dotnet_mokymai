using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7_generic
{
    internal class Validation<T1, T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }
        public void ShowValueTypes(T1 Value1, T2 Value2)
        {
            Console.WriteLine($"Value1 is {Value1.GetType()}");
            Console.WriteLine($"Value2 is {Value2.GetType()}");
        }
    }
}
