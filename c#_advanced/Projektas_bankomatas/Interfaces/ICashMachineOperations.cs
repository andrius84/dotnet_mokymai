using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_bankomatas.Interfaces
{
    public interface ICashMachineOperations
    {
        public Guid CheckCardGuidNumber(string id);
    }
}
