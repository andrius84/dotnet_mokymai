using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_bankomatas.Models
{
    public class Users
    {
        public Guid CardId { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string Password { get; set; }
        public Users(Guid cardId, string name, decimal balance, string password)
        {
            CardId = cardId;
            Name = name;
            Balance = balance;
            Password = password;
        }
    }
}
