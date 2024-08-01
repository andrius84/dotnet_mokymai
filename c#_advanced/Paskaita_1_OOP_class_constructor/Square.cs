using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_1_OOP_class_constructor
{
    internal class Square
    {
        public Square(double a)
        {
            A = a;
        }
        public double A { get; set; }

        public double GetArea()
        {
            return A * A;
        }
    }
}
