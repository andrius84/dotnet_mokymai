using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7_generic
{
    internal class Generator<T>
    {   
        public void Show(T figure)
        {
            Console.WriteLine($"Figuros plotas yra {figure}");
        }
    }
}
