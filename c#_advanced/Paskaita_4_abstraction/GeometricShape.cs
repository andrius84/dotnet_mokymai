using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_4_abstraction
{
    public abstract class GeometricShape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

    }
    public class Triangle : GeometricShape
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public override double GetPerimeter()
        {
            return A + B + C;
        }
    }
    public class Square : GeometricShape
    {
        public Square(double a)
        {
            A = a;
        }
        public double A { get; set; }
        public override double GetArea()
        {
            return A * A;
        }
        public override double GetPerimeter()
        {
            return 4 * A;
        }
    }
}
