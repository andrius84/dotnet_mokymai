using Projektas_bankomatas.Interfaces;
using Projektas_bankomatas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_bankomatas.Services
{
    public class CashMachineOperations : ICashMachineOperations
    {
        private readonly string _filePath;
        public CashMachineOperations(string filePath)
        {
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
            if (cardGuid == new Guid(balance[0]) && pin == balance[3])
            {
                return balance;
            }
            else
            {
                Console.WriteLine("Wrong card number or pin");
                return null;
            }
        }
        public void ShowMenu(Users user)
        {
            Console.Clear();
            Console.WriteLine("Welcome " + user.Name);
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Exit");
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
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
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
                else
                {
                    Console.WriteLine("Card not found");
                    return null;
                }
            }
            return balance;
        }
        public void CheckBalance(Guid cardid)
        {
            var balance = GetUserInfo(cardid);
            Console.WriteLine("Your balance is: " + balance[2]);
        }
        public void WithdrawMoney(Users user)
        {
            Console.WriteLine("Enter the amount you want to withdraw: ");
            var amount = double.Parse(Console.ReadLine());
            if (amount > user.Balance)
            {
                Console.WriteLine("Not enough money");
            }
            else
            {
                user.Balance -= amount;
                Console.WriteLine("You have withdrawn " + amount + " euros");
                Console.WriteLine("Your balance is: " + user.Balance);
                WriteUserBalanceToFile(user);
                var machineinfo = new CashMachine("../../../machineinfo.csv");
                ReadMachineInfo(machineinfo);
                machineinfo.AmountOfMoney -= (decimal)amount;
                WriteMachineInfoToFile(machineinfo);
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
                    Exception ex = new Exception("Machine info not found");
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
                    Exception ex = new Exception("Machine info not found");
                }
            }
        }
    }
}   

