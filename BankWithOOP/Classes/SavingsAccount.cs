using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankWithOOP.Classes
{

    // SavingsAccount inherits from BankAccount and so does the CheckingAccount so we are having two child classes here.
    // This is an example of inheritance in OOP and it inherit the properties and methods of the parent class (BankAccount) like Deposit, Withdraw and GetBalance.
    public class SavingsAccount : BankAccount
    {
        private decimal interestRate; // interest rate specific to savings account

        public SavingsAccount(decimal initialBalance, decimal interestRate)
            : base(initialBalance)  // call parent constructor
        {
            this.interestRate = interestRate; // set interest rate
        }

        public void AddInterest() // method to add interest to the balance
        {
            Deposit(GetBalance() * interestRate); // add interest to the balance
        }

        public override void Withdraw(decimal amount)
        {
            if (GetBalance() - amount < 0) // Must keep at least 0 in account which means you cant go into debt.
            {
                Console.WriteLine("Cannot withdraw, minimum balance must remain 0, You cant go into debt my man!."); // Message if you try to withdraw more than you have.
            }
            else
            {
                base.Withdraw(amount); // Reuse parent’s withdraw logic
            }
        }
    }
}


