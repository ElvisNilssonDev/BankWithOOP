using BankWithOOP.Classes;

namespace BankWithOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Here we are using the BankAccount class to create an account and perform some operations on it.

            var account = new BankAccount(0);   // create a new account object with an initial balance of 0
            account.Deposit(1000);              // add 100 (now balance is 1000)
            account.Withdraw(300);              // take out 30 (now balance is 700)
            Console.WriteLine(account.GetBalance()); // prints 700
            Console.WriteLine("This is your BankAccount money!");
            Console.WriteLine("-----------------------------------");
            
            // Here we are using the CheckingAccount class which inherits from BankAccount and we will do the same with CheckingAccount.

            var savings = new SavingsAccount(200000m, 0.02m); //I set my initial balance to 200000 and my interest rate to 2% because well its realistic. And (m) stands for decimal literal.
            savings.AddInterest(); // This method adds interest to the balance based on the interest rate we set when we created the object also because in a real savings account you get interest on your money.
            Console.WriteLine(savings.GetBalance()); // 204000 is the number we should get here.
            Console.WriteLine("This is your SavingsAccount money!");
            Console.WriteLine("-----------------------------------");

            var checking = new CheckingAccount(10000m); // start with 10,000
            checking.DeductMonthlyFee();              // fee of 15 is taken because of the method we created in the CheckingAccount class and having the account costs money.
            Console.WriteLine(checking.GetBalance()); // prints 9985 because of the fee.
            Console.WriteLine("This is your CheckingAccount money!");
            Console.WriteLine("-----------------------------------");
            Console.ReadLine(); // This is to keep the console window open until we press a key.


        }
    }
}
