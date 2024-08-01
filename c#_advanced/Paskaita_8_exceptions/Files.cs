using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_8_exceptions
{
    internal class Files
    {
        public void ReadFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(@"C:\Users\Vartotojas\Desktop\test.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Nurodytas neteisingas failo kelias");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Nurodytas neteisingas direktorijos kelias");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Failas nerastas");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Neturite teisiu nuskaityti failo");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Kelias per ilgas");
            }
            catch (IOException)
            {
                Console.WriteLine("Ivyko klaida nuskaitant faila");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Nepalaikomas operacijos tipas");
            }
            catch (Exception e)
            {
                Console.WriteLine("Klaida: " + e.Message);
            }
        }
    }
}
