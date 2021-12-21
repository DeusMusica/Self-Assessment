using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Customer jGalleys = new Customer("John Galloway", false);
            DepositAccount depo = new DepositAccount(3m, .12m, jGalleys);
            bank.AddAccount(depo);
            bank.ListAccounts();
            Console.WriteLine("Testing interest calc");
            depo.Deposit(2997m);
            depo.Withdraw(2000m);
            Console.WriteLine(depo.CalcInterest(36));
        }
    }
}
