using Projektas_bankomatas.Models;
using Projektas_bankomatas.Services;

namespace Projektas_bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var card1 = new CardsFileReader("../../../validcards.csv");
            var mycard = card1.ChooseCard();

            Console.WriteLine(mycard);
            Console.ReadKey();

            var cashmachine = new CashMachineOperations("../../../users.csv");
            cashmachine.ShowMenu(1);

            Console.ReadKey();

        }
    }
}
