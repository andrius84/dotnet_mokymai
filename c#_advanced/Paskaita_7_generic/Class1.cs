using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7_generic
{
    internal class Class1<T1, T2>
    {
        private T1 FistValue;
        private T2 SecondValue; 
        public void PrintProperties1()
        {
            Console.WriteLine($"FistValue is {FistValue}");
        }
        public void PrintProperties2()
        {
            Console.WriteLine($"SecondValue is {SecondValue}");
        }
        public void ChangeT1Value(T1 firstValue)
        {
            this.FistValue = firstValue;
        }
        public void ChangeT2Value(T2 secondValue)
        {
            this.SecondValue = secondValue;
        }

    }
}
