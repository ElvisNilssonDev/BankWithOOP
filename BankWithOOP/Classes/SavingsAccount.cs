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
    }

    public class CheckingAccount : BankAccount
    {
        private decimal fee = 15.00m; // monthly fee for checking account and m is for decimal literal wich is more accurate for money calculations.
        // You can change the fee to whatever you want just put a (.) before or after to change the outcome 1.0 is 100% so do what you want with that in mind.

        public CheckingAccount(decimal initialBalance) // constructor
            : base(initialBalance)
        {
        }

        public void DeductMonthlyFee() // method to deduct monthly fee
        {
            Withdraw(fee); // withdraw the fee from the balance
        }
    }

}
