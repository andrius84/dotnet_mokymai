using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_2_class_methods
{
    internal class Order
    {
        public Order(decimal amount, int orderId)
        {
            amount = Amount;
            orderId = OrderId;
        }
        public int OrderId { get; set; }
        public decimal Amount { get; set; } 
        public void PrintOrder()
        {
            Console.WriteLine($"Processing order {OrderId} with amount {Amount} ");
        }
    }
}
