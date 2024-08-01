using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7_generic
{
    internal class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }

        public string GetArea()
        {
            var area = Base * Height;
            return area.ToString();
        }
        public override string ToString()
        {
            return $"{Name} {GetArea()}";
        }
    }
}
