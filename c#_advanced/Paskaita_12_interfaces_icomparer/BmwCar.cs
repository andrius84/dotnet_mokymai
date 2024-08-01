namespace Paskaita_12_interfaces_icomparer
{
    public class BmwCar : Car
    {
        public bool IsXDrive { get; set; }
        public BmwCar(bool isXDrive, string model, int fuel)
        {
            IsXDrive = isXDrive;
            Model = model;
            Fuel = fuel;
        }
    }

}
