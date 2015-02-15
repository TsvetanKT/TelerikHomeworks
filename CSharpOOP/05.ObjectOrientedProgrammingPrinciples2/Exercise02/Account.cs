namespace Exercise02
{
    using System;
    public abstract class Account : IAccount
    {
        public Account (CustomerType theCustomer, DateTime created, decimal balance, decimal interestRate)
        {
            this.Customer = theCustomer;
            this.CreatedDate = created;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public CustomerType Customer { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public decimal Balance { get; protected set; }

        public decimal InterestRate { get; private set; }

        public abstract decimal CalculateInterestAmount(DateTime date);

        public void Deposit(decimal amount)
        {
            this.Balance+=amount;
        }
    }
}
