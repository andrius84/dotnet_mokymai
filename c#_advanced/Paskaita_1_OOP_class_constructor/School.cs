using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_1_OOP_class_constructor
{
    internal class School
    {
        public School(string name, string city, int numberofstudents)
        {
            Name = name;
            City = city;
            numberOfStudents = numberofstudents;
        }
        public string Name { get; set; }
        public string City { get; set; }
        public int numberOfStudents { get; set; }
    }
}
