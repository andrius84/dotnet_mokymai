using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas_bankomatas.Models;

namespace Projektas_bankomatas.Interfaces
{
    public interface ICashMachineUserInterface
    {
        List<string> ShowLoginMenu(string cardNumber);
        void ShowMenu(Users user);
        void ShowLast5Transactions(Users user);

    }
}
