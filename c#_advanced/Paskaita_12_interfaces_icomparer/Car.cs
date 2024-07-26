using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_12_interfaces_icomparer
{
    public abstract class Car : IVehicle
    {
        public string Model { get; set; }
        public int Fuel { get; set; }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Car is driving");
            }
            else
            {
                Console.WriteLine("Car is out of fuel");
            }
        }
        public void Refuel(int fuel)
        {
            if (fuel > 0)
            {
                Console.WriteLine("Car is refueling");
                Fuel += fuel;
            }
            else
            {
                Console.WriteLine("Pay for fuel");
            }
        }
    }
}
