namespace Paskaita_12_interfaces_icomparer
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            var bmw = new BmwCar(true, "X5", 0);
            var audi = new AudiCar(true, "A6", 0);

            bmw.Drive();
            bmw.Refuel(50);
            bmw.Drive();
            Console.WriteLine();
            audi.Drive();
            audi.Refuel(60);
            audi.Drive();
            Console.WriteLine();
            Console.WriteLine($"BMW model: {bmw.Model}, fuel: {bmw.Fuel}, is xDrive: {bmw.IsXDrive}");
            Console.WriteLine($"Audi model: {audi.Model}, fuel: {audi.Fuel}, is Quattro: {audi.IsQuattro}");

            CarsFuelComparer carsModelComparer = new CarsFuelComparer();

            Console.WriteLine(carsModelComparer.Compare(bmw, audi));
            Console.WriteLine();

            if (carsModelComparer.Compare(bmw, audi) == 1)
            {
                Console.WriteLine("BMW has more fuel");
            }
            else if (carsModelComparer.Compare(bmw, audi) == -1)
            {
                Console.WriteLine("Audi has more fuel");
            }
            else
            {
                Console.WriteLine("Both cars have the same amount of fuel");
            }



        }
    }
}
