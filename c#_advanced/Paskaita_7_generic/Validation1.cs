namespace Paskaita_7_generic
{
    public class Validation1
    {
        public static void Validate<T>(T Value)
        {
            if (Value is null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                Console.WriteLine("Validation passed");
            }
        }
    }
}
