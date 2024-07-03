using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_4_abstraction
{
    public abstract class Human
    {
        public List<Vehicle> Vehicles { get; set; }
        public abstract void AddVehicle(Vehicle vehicle);
    }
    public class Driver : Human
    {
        public Driver()
        {
            Vehicles = new List<Vehicle>();
        }
        public override void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
    public class Passenger : Human
    {
        public Passenger()
        {
            Vehicles = new List<Vehicle>();
        }
        public override void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
    public class DrivingInstructor : Human
    {
        public DrivingInstructor()
        {
            Vehicles = new List<Vehicle>();
        }
        public override void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
}
