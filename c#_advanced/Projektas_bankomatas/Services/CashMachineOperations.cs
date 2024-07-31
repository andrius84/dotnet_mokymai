using Projektas_bankomatas.Interfaces;
using Projektas_bankomatas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Projektas_bankomatas.Services
{
    public class CashMachineOperations : ICashMachineOperations
    {
        private readonly List<ICashMachineTransactions> _transactions;
        private readonly string _filePath;

        public CashMachineOperations(ICashMachineTransactions transactions, string filePath)
        {
            _transactions = new List<ICashMachineTransactions> { transactions };
            _filePath = filePath;
        }
        public Guid CheckCardGuidNumber(string id)
        {
            var lines = File.ReadAllLines(_filePath);
            foreach (var line in lines)
            {
                var value = line.Split(';');
                if (value[0] == id)
                {
                    return new Guid(value[0]);
                }
            }
            return Guid.Empty;
        }

        public List<string> ShowLoginMenu(string cardNumber)
        {
            var cardGuid = CheckCardGuidNumber(cardNumber);
            Console.WriteLine($"Enter your pin: ");
            var pin = Console.ReadLine();
            var balance = GetUserInfo(cardGuid);
            for ( int i = 0; i < 2; i++)
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
                        CheckBalance(user.CardId);
                        break;
                    case "2":
                        WithdrawMoney(user);
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
        public List<string> GetUserInfo(Guid cardid)
        {
            var balance = new List<string>();
            var lines = File.ReadAllLines(_filePath);
            foreach (var line in lines)
            {
                if (line.Contains(cardid.ToString()))
                {
                    var value = line.Split(';');
                    for (int i = 0; i < value.Length; i++)
                    {
                        balance.Add(value[i]);
                    }
                }
            }
            return balance;
        }

        public void CheckBalance(Guid cardid)
        {
            var balance = GetUserInfo(cardid);
            Console.WriteLine("Your balance is: " + balance[2]);
            Console.ReadKey();
        }
        public void WithdrawMoney(Users user)
        {
            var transaction = new CashMachineTransactions("../../../transactions.csv");
            Console.WriteLine("Enter the amount you want to withdraw: ");
            var amount = decimal.Parse(Console.ReadLine());
            if (amount > user.Balance)
            {
                Console.WriteLine("Not enough money");
                Console.ReadKey();
            }
            else if (amount > 1000)
            {
                Console.WriteLine("You can't withdraw more than 1000 euros");
                Console.ReadKey();
            }
            else if (amount < 0)
            {
                Console.WriteLine("You can't withdraw negative amount");
                Console.ReadKey();
            }
            else if (transaction.CheckTransactionDayCount(user.CardId) >= 10)
            {
                Console.WriteLine("You have reached the limit of 10 transactions per day");
                Console.ReadKey();
            }
            else if (amount > 1000 - user.Balance)
            {
                Console.WriteLine("You can't withdraw more than 1000 euros per day");
                Console.ReadKey();
            }
            else
            {
                user.Balance -= amount;
                Console.WriteLine("You have withdrawn " + amount + " euros");
                Console.WriteLine("Your balance is: " + user.Balance);
                WriteUserBalanceToFile(user);
                var machineinfo = new CashMachine("../../../machineinfo.csv");
                ReadMachineInfo(machineinfo);
                machineinfo.AmountOfMoney -= amount;
                WriteMachineInfoToFile(machineinfo);
                var usertransaction = new Transactions(user.CardId, "Withdraw", amount);
                AddTransactionToFile(usertransaction);
                Console.WriteLine("Transaction completed");
                Console.ReadKey();
            }
        }

        public void WriteUserBalanceToFile(Users user)
        {
            var lines = File.ReadAllLines(_filePath);
            var newLines = new List<string>();
            foreach (var line in lines)
            {
                if (line.Contains(user.CardId.ToString()))
                {
                    var value = line.Split(';');
                    value[2] = user.Balance.ToString();
                    newLines.Add(string.Join(";", value));
                }
                else
                {
                    newLines.Add(line);
                }
            }
            File.WriteAllLines(_filePath, newLines);
        }

        public void WriteMachineInfoToFile(CashMachine machine)
        {
            var lines = File.ReadAllLines(machine.FilePath);
            var newInfo = new List<string>();
            foreach (var line in lines)
            {
                if (line.Contains("AmountOfMoney"))
                {
                    var value = line.Split(':');
                    value[1] = machine.AmountOfMoney.ToString();
                    newInfo.Add(string.Join(":", value));
                }
                else
                {
                    throw new Exception("Machine info not found");
                }
            }
            File.WriteAllLines(machine.FilePath, newInfo);
        }

        public void ReadMachineInfo(CashMachine machine)
        {
            var lines = File.ReadAllLines(machine.FilePath);
            foreach (var line in lines)
            {
                if (line.Contains("AmountOfMoney"))
                {
                    var value = line.Split(':');
                    machine.AmountOfMoney = decimal.Parse(value[1]);
                }
                else
                {
                    throw new Exception("Machine info not found");
                }
            }
        }
        public void ShowLast5Transactions(Users user)
        {
            var transactions = new CashMachineTransactions("../../../transactions.csv");
            var i = 0;
            var userTransactions = transactions.GetTransactions(user.CardId);
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
        private void AddTransactionToFile(Transactions transaction) => _transactions.ForEach(t => t.AddTransactionToFile(transaction.CardId, transaction.TransactionType, transaction.Amount));
    }
}   

