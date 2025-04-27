namespace Day6
{
    internal class CheckingAccount : Account
    {
        private double transactionFee;

        public CheckingAccount(double initialBalance, double fee) : base(initialBalance)
        {
            transactionFee = fee;
        }

        public override void Credit(double amount)
        {
            base.Credit(amount);
            balance -= transactionFee;
        }

        public override bool Debit(double amount)
        {
            bool success = base.Debit(amount);
            if (success)
            {
                balance -= transactionFee;
            }
            return success;
        }
    }
}
