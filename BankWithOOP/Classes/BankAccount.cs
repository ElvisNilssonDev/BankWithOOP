using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankWithOOP.Classes
{
    public class BankAccount // This is the class definition for a BankAccount. And underneathe we have the blueprint for encapsulation.
    {
        private decimal balance; // This field holds the account balance and its private so it can not be touched from the outside, only inside the code of this class.

        public BankAccount(decimal initialBalance) // Constructor to initialize the account with an initial balance (decimal is a more accurate way of doing float of double).
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount) // Method to deposit money into the account.
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance) // Check if there are sufficient funds before withdrawing. (I learnt that && means AND in a more code kinda way).
                balance -= amount;
        }

        public decimal GetBalance() // Method to get the current balance of the account.
        {
            return balance;
        }
    }
}
