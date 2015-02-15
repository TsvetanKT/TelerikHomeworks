namespace Exercise02
{
    using System;
    public interface IAccount
    {
        CustomerType Customer { get; }

        decimal Balance { get; }

        decimal InterestRate { get; }

        decimal CalculateInterestAmount(DateTime date);

        void Deposit(decimal amount);

    }
}
