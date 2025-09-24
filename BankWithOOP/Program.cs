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
            Console.ReadLine();
        }
    }
}
