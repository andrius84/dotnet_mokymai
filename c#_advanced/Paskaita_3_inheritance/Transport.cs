using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_3_inheritance
{
    public class Transport
    {
        public virtual int MeasureSpeed()
        {
            return 101;    
        }
    }

    public class Car : Transport
    {
        public override int MeasureSpeed()
        {
            return 201;
        }
    }
}
