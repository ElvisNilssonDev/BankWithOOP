using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankWithOOP.Classes
{
    public interface ITransaction // Interface for transactions
    {
        void Execute(); // Method to execute the transaction but we dont implement it here because its an interface.
                        // You have to implement it in the classes that inherit from this interface and declare exactly what they do.
    }

    public abstract class Transaction : ITransaction
    {
        protected BankAccount account; // The account involved in the transaction
        protected decimal amount;      

        public Transaction(BankAccount account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
        }

        public abstract void Execute(); // Abstract method to be implemented by subclasses
    }

    public class DepositTransaction : Transaction
    {
        public DepositTransaction(BankAccount account, decimal amount)
            : base(account, amount) { }

        public override void Execute()
        {
            Console.WriteLine($"Depositing {amount} to account.");
            account.Deposit(amount); // Add money

        }
    }

    public class WithdrawTransaction : Transaction
    {
        public WithdrawTransaction(BankAccount account, decimal amount)
            : base(account, amount) { }

        public override void Execute()
        {
            Console.WriteLine($"Withdrawing {amount} from account.");
            account.Withdraw(amount); // Remove money
        }
    }
}
// In reality we have already declared previously the Deposit and Withdraw methods in the BankAccount class
// so this is a bit redundant but it shows how you can use interfaces to define contracts for classes and enforce certain methods to be implemented.
// Also VisualStudio makes my speach more refined and I love that. Usually I dont talk like this. But its fun to see how it changes my speach patterns. I feel fancy now.
