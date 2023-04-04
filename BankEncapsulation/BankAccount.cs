using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double deposit) {
            balance += deposit;
            Console.WriteLine($"Deposited {deposit}. Balance is now {balance}");
        }

        public double GetBalance()
        {
            Console.WriteLine("Balance:");
            return balance;
        }
    }
}
