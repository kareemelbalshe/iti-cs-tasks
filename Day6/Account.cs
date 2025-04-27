using System;

namespace Day6
{
    internal class Account
    {
        protected double balance;

        public Account(double initialBalance)
        {
            if (initialBalance >= 0)
                balance = initialBalance;
            else
                balance = 0;
        }

        public virtual void Credit(double amount)
        {
            balance += amount;
        }

        public virtual void Debit(double amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Debit amount exceeded account balance.");
        }

        public double GetBalance()
        {
            return balance;
        }

    }
}
