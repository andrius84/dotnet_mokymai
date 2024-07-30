using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_bankomatas.Services
{
    public class CardsFileReader
    {
        private readonly string _filePath;
        public CardsFileReader(string filePath)
        {
            _filePath = filePath;
        }

        public string ChooseCard()
        {
            try
            {
                string[] alllines = File.ReadAllLines(_filePath);
                int i = 1;
                foreach (var line in alllines)
                {
                    Console.WriteLine($"{i++}: {line}");
                }
                Console.WriteLine("Įveskite skaičių, kurią kortelę naudosite");
                int choose = int.Parse(Console.ReadLine());
                string card = alllines[choose-1];
              
                return card;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null; 
            }
        }
    }
}
