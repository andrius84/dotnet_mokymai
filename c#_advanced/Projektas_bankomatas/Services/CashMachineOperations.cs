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
        private readonly ICashMachineTransactions _transaction;
        private readonly CashMachine _machine;
        private readonly string _filePath;

        public CashMachineOperations(ICashMachineTransactions transactions, CashMachine machine, string filePath)
        {
            _transaction = transactions;
            _filePath = filePath;
            _machine = machine;
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
            else if (_transaction.CheckTransactionDayCount(user.CardId) >= 10)
            {
                Console.WriteLine("You have reached the limit of 10 transactions per day");
                Console.ReadKey();
            }
            else if (amount > 1000 - user.Balance)
            {
                Console.WriteLine("You can't withdraw more than 1000 euros per day");
                Console.ReadKey();
            }
            else if (amount % 2 != 0)
            {
                Console.WriteLine("You can't withdraw odd amount");
                Console.ReadKey();
            }
            else
            {
                user.Balance -= amount;
                Console.WriteLine("You have withdrawn " + amount + " euros");
                Console.WriteLine("Your balance is: " + user.Balance);
                WriteUserBalanceToFile(user);
                ReadMachineInfo(_machine);
                _machine.AmountOfMoney -= amount;
                WriteMachineInfoToFile(_machine);
                _transaction.AddTransactionToFile(amount: amount, cardId: user.CardId, transactionType: "Withdraw");
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
        private void AddTransactionToFile(Guid cardId, string transactionType, decimal amount) => _transaction.AddTransactionToFile(cardId, transactionType, amount);
    }
}   

