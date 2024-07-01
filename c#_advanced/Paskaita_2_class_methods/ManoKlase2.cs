using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_2_class_methods
{
    public class ManoKlase2
    {
        private string manoKintamasis = "Tekstas, kuri reikia atspausdinti";  
        public void KintamojoPakeitimas()
        {
            manoKintamasis = "nauja kintamojo reiksme";
        }
        public void ManoMetodas()
        {
            Console.WriteLine(manoKintamasis);
        }

    }
}
