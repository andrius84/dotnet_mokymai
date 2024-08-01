using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_2_class_methods
{
    internal class Circle
    {
        public int Radius { get; set; }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
