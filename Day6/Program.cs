using System;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount saving = new SavingsAccount(1000, 0.05);
            Console.WriteLine("Saving balance: " + saving.GetBalance()); // 1000
            Console.WriteLine("Saving interest: " + saving.CalculateInterest()); // 50

            CheckingAccount checking = new CheckingAccount(500, 10); // رصيد 500 ورسوم 10 لكل عملية
            checking.Credit(100);
            Console.WriteLine("Checking balance after credit: " + checking.GetBalance()); // 590 (500 + 100 - 10)

            checking.Debit(200);
            Console.WriteLine("Checking balance after debit: " + checking.GetBalance()); // 380 (590 - 200 - 10)
        }
    }
}
