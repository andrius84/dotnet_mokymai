using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_3_inheritance
{
    public class Clients
    {
        public Clients(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class Vehicles
    {
        public Vehicles(string brand, string year, string fuelType)
        {
            Brand = brand;
            Year = year;
            FuelType = fuelType;
        }
        public string Brand { get; set; }
        public string Year { get; set; }
        public string FuelType { get; set; }
        
        public void Drive()
        {
            Console.WriteLine("Vaziuoja");
        }
        public void PrintMaxSpeed()
        {
            Console.WriteLine("Maksimalus greitis");
        }
        public void GetCapacity()
        {
            Console.WriteLine("Talpa");
        }
        public void GetFuelEfficiency()
        {
            Console.WriteLine("Kuro sanaudos");
        }
    }
    public class Payments
    {
        public Payments(double paymentAmount, int paymentType, string paymentStatus)
        {
            PaymentAmount = paymentAmount;
            PaymentType = paymentType;
            PaymentStatus = paymentStatus;
            PaymentDate = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public string PaymentDate { get; set; }
        public double PaymentAmount { get; set; }
        public int PaymentType { get; set; }
        public string PaymentStatus { get; set; }

    }
}
