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
            {
                balance = 0;
                Console.WriteLine("Initial balance was invalid. Set to 0.");
            }
        }

        public virtual void Credit(double amount)
        {
            balance += amount;
        }

        public virtual bool Debit(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
            else
            {
                balance -= amount;
                return true;
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
