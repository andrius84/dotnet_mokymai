using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_3_inheritance
{
    public class Employee
    {
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public string Name { get; set; }
        public double Salary { get; set; }

    }
}
