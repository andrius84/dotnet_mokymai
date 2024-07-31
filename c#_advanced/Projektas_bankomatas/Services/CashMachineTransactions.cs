using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas_bankomatas.Interfaces;

namespace Projektas_bankomatas.Services
{
    public class CashMachineTransactions : ICashMachineTransactions
    {
        private readonly string _filePath;
        public CashMachineTransactions(string filePath)
        {
            _filePath = filePath;
        }
        public void AddTransactionToFile(Guid cardId, string transactionType, decimal amount)
        {
            try
            {
                var transaction = $"{cardId};{transactionType};{amount};{DateTime.Now}";
                File.AppendAllText(_filePath, transaction + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while logging: " + ex.Message);
            }
        }
        public List<string> GetTransactions(Guid cardId)
        {
            var transactions = new List<string>();
            try
            {
                var lines = File.ReadAllLines(_filePath);
                foreach (var line in lines)
                {
                    var value = line.Split(';');
                    if (value[0] == cardId.ToString())
                    {
                        transactions.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while reading transactions: " + ex.Message);
            }
            return transactions;
        }
        public int CheckTransactionDayCount(Guid cardId)
        {
            var transactions = GetTransactions(cardId);
            var count = 0;
            foreach (var transaction in transactions)
            {
                var value = transaction.Split(';');
                if (DateTime.Parse(value[3]).Date == DateTime.Now.Date)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
