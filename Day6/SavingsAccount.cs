namespace Day6
{
    internal class SavingsAccount : Account
    {
        private double interestRate;

        public SavingsAccount(double initialBalance, double interestRate) : base(initialBalance)
        {
            this.interestRate = interestRate;
        }

        public double CalculateInterest()
        {
            return balance * interestRate;
        }
    }
}
