using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_10.Entities
{
    public class Pacientas
    {
        public int Id { get; set; } 
        public string Vardas { get; set; } 
        public string Pavarde { get; set; } 
        public DateTime? GimimoData { get; set; } 

        public ICollection<Vizitas> Vizitai { get; set; }
        public ICollection<Gydytojas> Gydytojai { get; set; }
    }
}
