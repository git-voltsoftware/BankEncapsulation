using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance;
        public BankAccount()
        { }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public double GetBalance()
        {
            return balance;
        }

    }
}
