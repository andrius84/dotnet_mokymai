using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_12_interfaces_icomparer
{
    internal class CarsFuelComparer : IComparer<Car>
    {
            public int Compare(Car? x, Car? y)
            {
                if (x == null && y == null)
                {
                    return 0;
                }
                if (x == null)
                {
                    return 1;
                }
                if (y == null)
                {
                    return -1;
                }
                if (x.Fuel > y.Fuel)
                {
                    return 1;
                }
                if (x.Fuel < y.Fuel)
                {
                    return -1;
                }
                return 0;
   
        }
    }
}