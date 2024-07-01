using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_1_OOP_class_constructor
{
    internal class Circle
    {
        public Circle(double r)
        {
            R = r;
        }
        public double R { get; set; }

        public double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
