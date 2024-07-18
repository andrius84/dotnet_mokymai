using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_8_exceptions
{
    public class Class1
    {

        public void GetAllExceptions<T>(T b)
        {
            double c = 0;
            try
            {
                c = Convert.ToDouble(b);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"The value is {b}");
                Console.WriteLine($"The value after conversion is {c}");
            }
        }
    }
}
