using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_5_access_modifiers
{
    internal class Employee
    {
        public virtual void GetSalary()
        {
            Console.WriteLine("Employee salary");
        }
    }
    internal class Manager : Employee
    {
        public override sealed void GetSalary()
        {
            Console.WriteLine("Manager salary: 5000");
        }
    }
    internal class Developer : Employee
    {
        public override sealed void GetSalary()
        {
            Console.WriteLine("Developer salary: 4000");
        }
    }
}
