using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_1_OOP_class_constructor
{
    internal class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        } 
        public Person(int height)
        {
            Height = height;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
    }
}
