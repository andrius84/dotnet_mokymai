using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_bankomatas.Models
{
    public class CashMachine
    {
        public CashMachine(string filePath)
        {
            FilePath = filePath;
        }
        public string FilePath { get; set; }
        public decimal AmountOfMoney { get; set; }
        public int AmountIn100 { get; set; }
        public int AmountIn50 { get; set; }
        public int AmountIn5 { get; set; }

    }
}
