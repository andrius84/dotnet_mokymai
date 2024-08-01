using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_9_extensions
{
    internal class Cars
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public Cars(string model, string manufacturer, int year, int price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Model} {Manufacturer} {Year} {Price}";
        }
    }
}
