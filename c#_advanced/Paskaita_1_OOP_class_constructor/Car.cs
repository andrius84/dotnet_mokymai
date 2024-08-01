using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_1_OOP_class_constructor
{
    internal class Car
    {
        public Car(bool engineStart)
        {
            EngineStart = engineStart;
        }
        public bool EngineStart { get; set; }
        public Engine Engine { get; set; }

        public void EngineRun()
        {
            if (EngineStart)
            {
                Engine = new Engine("Variklis paleistas");
            }
            else
            {
                Engine = new Engine("Variklis isjungtas");
            }
        }

    }
}
