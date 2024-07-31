using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_bankomatas.Models
{
    public class Transactions
    {
        public Transactions(Guid cardId, string transactionType, decimal amount)  
        {
            CardId = cardId;
            TransactionType = transactionType;
            Amount = amount;
        }
        public Guid CardId { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
