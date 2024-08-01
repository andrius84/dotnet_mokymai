using Projektas_bankomatas.Interfaces;
using Projektas_bankomatas.Models;
using Projektas_bankomatas.Services;

namespace Projektas_bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CashMachine machine = new CashMachine("../../../machineinfo.csv");
            ICashMachineTransactions cashMachineTransactions = new CashMachineTransactions("../../../transactions.csv");
            ICashMachineOperations cashMachineOperations = new CashMachineOperations(cashMachineTransactions, machine, "../../../usersinfo.csv");
            ICashMachineUserInterface cashMachineUserInterface = new CashMachineUserInterface(cashMachineTransactions, cashMachineOperations);

            var cards = new CardsFileReader("../../../validcards.csv");
            var mycard = cards.ChooseCard();
            Console.WriteLine(mycard);

            var userdata = cashMachineUserInterface.ShowLoginMenu(mycard);
            var user = new Users(new System.Guid(userdata[0]), userdata[1], decimal.Parse(userdata[2]), userdata[3]);

            cashMachineUserInterface.ShowMenu(user);

            Console.ReadKey();
        }
    }
}
