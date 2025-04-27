using System;

namespace Day6
{
    internal class CheckingAccount : Account
    {
        private double feePerTransaction; 

        public CheckingAccount(double initialBalance, double fee) : base(initialBalance)
        {
            this.feePerTransaction = fee;
        }

        public override void Credit(double amount)
        {
            balance += amount;
            balance -= feePerTransaction; 
        }

        public override void Debit(double amount)
        {
            if (amount + feePerTransaction <= balance)
            {
                balance -= (amount + feePerTransaction);
            }
            else
            {
                Console.WriteLine("Debit amount exceeded account balance.");
            }
        }
    }
}
