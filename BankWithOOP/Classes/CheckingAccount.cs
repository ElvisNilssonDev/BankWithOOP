using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankWithOOP.Classes
{
    public class CheckingAccount : BankAccount
    {
        private decimal fee = 15.00m; // monthly fee for checking account and m is for decimal literal wich is more accurate for money calculations.
                                      // You can change the fee to whatever you want just put a (.) before or after to change the outcome 1.0 is 100% so do what you want with that in mind.

        public CheckingAccount(decimal initialBalance) // constructor
            : base(initialBalance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (GetBalance() - amount < -500) // Allow overdraft up to -500 (We are now in debt).
            {
                Console.WriteLine("Overdraft limit reached!");
            }
            else
            {
                base.Withdraw(amount); // Use parent logic for balance deduction and call the Withdraw method from the parent class (BankAccount).
            }
        }
        public void DeductMonthlyFee() // method to deduct monthly fee
        {
            Withdraw(fee); // withdraw the fee from the balance
        }
    }
}
