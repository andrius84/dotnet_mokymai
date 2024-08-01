using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_2_class_methods
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
        public int GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
