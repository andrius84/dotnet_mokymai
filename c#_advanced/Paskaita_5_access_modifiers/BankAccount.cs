using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_5_access_modifiers
{
    internal class BankAccount
    {
        public BankAccount( double getbalance)
        {
            Balance = getbalance;
        }
        private double balance;
        public double Balance { get { return balance; } set { balance = value; } }
        private void SetBalance(double setbalance)
        {
            setbalance = balance;
        }
        protected void PrintBalance()
        {
            Console.WriteLine($"Balansas: {balance}");
        }
    }
    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount(double getbalance, double getinterestrate) : base(getbalance)
        {
            Balance = getbalance;
            InterestRate = getinterestrate;
        }
        private double balance;
        public double Balance { get { return balance; } set { balance = value; } }
        private double InterestRate { get; set; }
        public void CalculateInterest()
        {
            double interest = balance * InterestRate;
            Console.WriteLine($"Palūkanos: {interest}");
            balance += interest;
            Console.WriteLine($"Balansas po palūkanų: {balance}");
        }
    }
    internal class CheckingAccount : BankAccount
    {
        public CheckingAccount(double getbalance, double getoverdraftLimit) : base(getbalance)
        {
            Balance = getbalance;
            getoverdraftLimit = OverdraftLimit;
        }
        private double balance;
        protected double Balance { get { return balance; } set { balance = value; } }
        private double OverdraftLimit { get; set; }
        public void Withdraw(double amount)
        {
            if (amount <= balance + OverdraftLimit)
            {
                balance -= amount;
                Console.WriteLine($"Išimta suma: {amount}");
                Console.WriteLine($"Balansas po išėmimo: {balance}");
            }
            else
            {
                Console.WriteLine("Nepakankamas balansas");
            }
        }



    }
}
