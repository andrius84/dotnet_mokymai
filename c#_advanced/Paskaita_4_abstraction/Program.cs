namespace Paskaita_4_abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var Triangle1 = new Triangle(3, 4, 5);
            //var Triangle2 = new Triangle(3, 5, 6);
            //var Square1 = new Square(4);
            //var Square2 = new Square(5);

            //var ListOfShapes = new List<GeometricShape>();
            //ListOfShapes.Add(Triangle1);
            //ListOfShapes.Add(Triangle2);
            //ListOfShapes.Add(Square1);
            //ListOfShapes.Add(Square2);

            //foreach (var shape in ListOfShapes)
            //{
            //    Console.WriteLine($"Figuros {shape} plotas: {shape.GetArea()}");
            //    Console.WriteLine($"Figuros {shape} perimetras: {shape.GetPerimeter()}");
            //}


            var car = new Car("Audi", 2010);
            var motorcycle = new Motorcycle("Suzuki", 2019);
            var truck = new Truck("Volvo", 2015);

            var ListOfVehicles = new List<Vehicle>();

            ListOfVehicles.Add(car);
            ListOfVehicles.Add(motorcycle);
            ListOfVehicles.Add(truck);

            foreach (var vehicle in ListOfVehicles)
            {
                vehicle.Drive();
            }

            var Driver = new Driver();
            var Passenger = new Passenger();
            var DrivingInstructor = new DrivingInstructor();

            Driver.AddVehicle(car);
            Driver.AddVehicle(motorcycle);
            Passenger.AddVehicle(motorcycle);
            DrivingInstructor.AddVehicle(truck);

            foreach (var vehicle in Driver.Vehicles)
            {
                Console.WriteLine($"Driver drives {vehicle.Name}");
            }
            foreach (var vehicle in Passenger.Vehicles)
            {
                Console.WriteLine($"Passenger drives {vehicle.Name}");
            }
            foreach (var vehicle in DrivingInstructor.Vehicles)
            {
                Console.WriteLine($"Driving instructor drives {vehicle.Name}");
            }
        }
    }
}
