namespace Paskaita_12_interfaces_icomparer
{
    public class AudiCar : Car
    {
        public bool IsQuattro { get; set; }
        public AudiCar(bool isQuattro, string model, int fuel)
        {
            IsQuattro = isQuattro;
            Model = model;
            Fuel = fuel;
        }
    }

}
