using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_bankomatas.Interfaces
{
    public interface ICashMachineTransactions
    {
        void AddTransactionToFile(Guid cardId, string transactionType, decimal amount);
    }
}
