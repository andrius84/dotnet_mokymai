using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Paskaita_1_OOP_class_constructor
{
    internal class Store
    {
        public Store(string name, string openDate, List<string> productName)
        {
            Name = name;
            OpenDate = openDate;
            ProductName = productName;
        }
        public string Name { get; set; }
        public string OpenDate { get; set; }
        public List<string> ProductName { get; set; }
    }
}

