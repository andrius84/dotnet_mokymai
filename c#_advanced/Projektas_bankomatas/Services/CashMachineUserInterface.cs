using Projektas_bankomatas.Interfaces;
using Projektas_bankomatas.Models;
using Projektas_bankomatas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_bankomatas.Services
{
    internal class CashMachineUserInterface : ICashMachineUserInterface
    {
        private readonly ICashMachineTransactions _transaction;
        private readonly ICashMachineOperations _operations;

        public CashMachineUserInterface(ICashMachineTransactions transactions, ICashMachineOperations operations)
        {
            _transaction = transactions;
            _operations = operations;
        }

        public List<string> ShowLoginMenu(string cardNumber)
        {
            var cardGuid = _operations.CheckCardGuidNumber(cardNumber);
            Console.WriteLine($"Enter your pin: ");
            var pin = Console.ReadLine();
            var balance = _operations.GetUserInfo(cardGuid);
            for (int i = 0; i < 2; i++)
            {
                if (cardGuid == new Guid(balance[0]) && pin == balance[3])
                {
                    return balance;
                }
                else
                {
                    Console.WriteLine("Wrong card number or pin");
                    Console.WriteLine("Enter your pin: ");
                    pin = Console.ReadLine();
                }
            }
            Console.WriteLine("Card blocked");
            Environment.Exit(0);
            return null;
        }
        public void ShowMenu(Users user)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome " + user.Name);
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Show last 5 transactions");
                Console.WriteLine("4. Exit");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        _operations.CheckBalance(user.CardId);
                        break;
                    case "2":
                        _operations.WithdrawMoney(user);
                        break;
                    case "3":
                        ShowLast5Transactions(user);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }
        public void ShowLast5Transactions(Users user)
        {
            var i = 0;
            var userTransactions = _transaction.GetTransactions(user.CardId);
            userTransactions.Reverse();
            foreach (var transaction in userTransactions)
            {
                Console.WriteLine(transaction);
                i++;
                if (i == 5)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
