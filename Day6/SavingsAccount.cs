namespace Day6
{
    internal class SavingsAccount : Account
    {
        private double interestRate;

        public SavingsAccount(double initialBalance, double rate) : base(initialBalance)
        {
            interestRate = rate;
        }

        public double CalculateInterest()
        {
            return balance * interestRate;
        }
    }
}
