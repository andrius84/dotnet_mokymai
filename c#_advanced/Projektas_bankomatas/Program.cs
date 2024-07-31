using Projektas_bankomatas.Interfaces;
using Projektas_bankomatas.Models;
using Projektas_bankomatas.Services;

namespace Projektas_bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICashMachineTransactions transactions = new CashMachineTransactions("../../../transactions.csv");
            var cashmachine = new CashMachineOperations(transactions, "../../../usersinfo.csv");

            var cards = new CardsFileReader("../../../validcards.csv");
            var mycard = cards.ChooseCard();
            Console.WriteLine(mycard);

            var cashmachineinfo = new CashMachine("../../../machineinfo.csv");
            
            var userdata = cashmachine.ShowLoginMenu(mycard);
            var user1 = new Users(new System.Guid(userdata[0]), userdata[1], decimal.Parse(userdata[2]), userdata[3]);
            cashmachine.ShowMenu(user1);
            Console.ReadKey();
        }
    }
}
