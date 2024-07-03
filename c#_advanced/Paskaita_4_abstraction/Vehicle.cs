using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_4_abstraction
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Vehicle(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public abstract void Drive();
        public abstract void Stop();
    }
    public class Car : Vehicle
    {
        public Car(string name, int year) : base(name, year)
        {
        }
        public bool IsElectric { get; set; }
        public int NumberOfDoors { get; set; }
        public override void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stopping");
        }
    }
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string name, int year) : base(name, year)
        {
        }
        public string Type { get; set; }
        public override void Drive()
        {
            Console.WriteLine("Motorcycle is driving");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping");
        }
    }
    public class Truck : Vehicle
    {
        public Truck(string name, int year) : base(name, year)
        {
        }
        public int NumberOfWheels { get; set; }
        public override void Drive()
        {
            Console.WriteLine("Truck is driving");
        }

        public override void Stop()
        {
            Console.WriteLine("Truck is stopping");
        }
    }
}
