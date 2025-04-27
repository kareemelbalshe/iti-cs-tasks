using System;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount(1000.0, 0.05);
            CheckingAccount checking = new CheckingAccount(500.0, 2.0);

            Console.WriteLine("Savings Account Balance: " + savings.GetBalance());
            Console.WriteLine("Interest earned: " + savings.CalculateInterest());

            Console.WriteLine("\nChecking Account Balance: " + checking.GetBalance());
            checking.Credit(100.0);
            Console.WriteLine("After crediting 100 with fee, balance: " + checking.GetBalance());
            checking.Debit(50.0);
            Console.WriteLine("After debiting 50 with fee, balance: " + checking.GetBalance());
            checking.Debit(1000.0);
        }
    }
}
