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

        public virtual void Deposit(decimal amount) // Method to deposit money into the account.
        {
            if (amount > 0)
                balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (balance >= amount) // Check if there are sufficient funds before withdrawing. (Simple way off establishing if you are broke).
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount}, new balance:");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public decimal GetBalance() => balance; // Method to get the current balance and we use expression-bodied member syntax here because it is smoother and cleaner.

        protected void UpdateBalance(decimal newBalance) => balance = newBalance; // Protected method to update the balance, accessible in derived classes (Children of this class).

    }
}
