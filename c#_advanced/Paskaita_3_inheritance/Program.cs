namespace Paskaita_3_inheritance
{
    internal class Program
    {
        public void Main(string[] args)
        {
            //var car = new Car();
            //car.Speed = 100;
            //Console.WriteLine($"Automobilio greitis = {car.Speed}");
            //var bike = new Bike();
            //bike.Speed = 50;
            //Console.WriteLine($"Dviracio greitis = {bike.Speed}");

            //var Manager = new Manager("Jonas", 1000, new List<Employee>());

            //3.
            //var transport = new Transport();
            //var speed = transport.MeasureSpeed();
            //Console.WriteLine($"Transporto greitis = {speed}");
            //var car = new Car();
            //speed = car.MeasureSpeed();
            //Console.WriteLine($"Automobilio greitis = {speed}");

            //4.

        }
        public void ClientRegistration()
        {
            Console.WriteLine("Iveskite kliento varda");
            var name = Console.ReadLine();
            Console.WriteLine("Iveskite kliento telefono numeri");
            var phoneNumber = Console.ReadLine();
            var client = new Clients(name, phoneNumber);
        }
        public void ChooseCar()
        {
            Console.WriteLine("Pasirinkite automobili");
            Console.WriteLine("1. Audi ");
            Console.WriteLine("2. BMW ");
            Console.WriteLine("3. VW ");
            Console.WriteLine("4. Audi ");
            var car = Console.ReadLine();
            switch (car)
            {
                case "1":
                    var car1 = new Vehicles("Audi", "2010", "Diesel");
                    break;
                case "2":
                    var car2 = new Vehicles("BMW", "2015", "Petrol");
                    break;
                case "3":
                    var car3 = new Vehicles("VW", "2012", "Diesel");
                    break;
                case "4":
                    var car4 = new Vehicles("Audi", "2018", "Petrol");
                    break;
                default:
                    Console.WriteLine("Tokio automobilio nera");
                    break;
            }
        }
    }
}
