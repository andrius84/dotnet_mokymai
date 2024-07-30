using Projektas_bankomatas.Interfaces;
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
            return new Guid(id);
        }

        public void ShowMenu(int choose)
        {
            Console.Clear();
            var balance = GetUserInfo();
            Console.WriteLine($"Card number: {balance[0]}");
            Console.WriteLine($"Name: {balance[2]}");
            Console.WriteLine($"Balance: {balance[3]}");
            Console.WriteLine($"Last transactions: {null}");
            Console.WriteLine($"Withdraw money: {null}");
            Console.WriteLine($"Left times to withdraw: {null}");
            Console.WriteLine($"Left money to withdraw: {null} ");
        }
        
        public List<string> GetUserInfo()
        {
            var balance = new List<string>();
            var lines = File.ReadAllLines(_filePath);
            foreach (var line in lines)
            {
                var value = line.Split(';');
                for (int i = 0; i < value.Length; i++)
                {
                    balance.Add(value[i]);
                }
            }
            return balance;
        }
    }
}   

