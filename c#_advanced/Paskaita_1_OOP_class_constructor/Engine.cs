using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_1_OOP_class_constructor
{
    internal class Engine
    {

        public Engine(string status)
        {
            Status = status;
        }
        public string Status { get; set; }

    }
}
