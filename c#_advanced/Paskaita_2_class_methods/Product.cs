using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_2_class_methods
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ApplyDiscount(decimal discountPercentage)
        {
            return Price - (discountPercentage / 100);
        }
    }
}
