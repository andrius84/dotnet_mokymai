using Projektas_bankomatas.Models;
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
        public void CheckBalance(Guid cardId);
        public List<string> GetUserInfo(Guid cardId);
        public void WithdrawMoney(Users user);

    }
}
