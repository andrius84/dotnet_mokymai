﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_5_access_modifiers
{
    internal class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override sealed double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
