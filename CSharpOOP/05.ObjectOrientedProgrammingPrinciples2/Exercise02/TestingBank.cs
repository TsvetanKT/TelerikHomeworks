namespace Exercise02
{
    //02.A bank holds different types of accounts for its customers: deposit accounts, 
    //   loan accounts and mortgage accounts. Customers could be individuals or companies.
	//       All accounts have customer, balance and interest rate (monthly based). 
    //   Deposit accounts are allowed to deposit and with draw money. Loan and mortgage 
    //   accounts can only deposit money.
    //       All accounts can calculate their interest amount for a given period (in months).
    //   In the common case its is calculated as follows: number_of_months * interest_rate.
    //       Loan accounts have no interest for the first 3 months if are held by individuals 
    //   and for the first 2 months if are held by a company.
    //       Deposit accounts have no interest if their balance is positive and less than 1000.
    //       Mortgage accounts have ½ interest for the first 12 months for companies and no 
    //   interest for the first 6 months for individuals.
    //       Your task is to write a program to model the bank system by classes and interfaces. 
    //   You should identify the classes, interfaces, base classes and abstract actions and 
    //   implement the calculation of the interest functionality through overridden methods.

    using System;
    using System.Collections.Generic;
    class TestingBank
    {
        static void Main()
        {
            Console.WriteLine("02.Testing Bank");
            DateTime Date1 = DateTime.Parse("2/9/2010 8:33:21 AM");
            DateTime Date2 = DateTime.Parse("21/11/2013 8:33:21 PM");
            DateTime now = DateTime.Now;

            var s1 = new Loan (CustomerType.Individual, Date1, 5000, 0.03m);
            var s2 = new Deposit (CustomerType.Company, Date1, 560, 0.02m);
            var s3 = new Mortgage (CustomerType.Company, Date1, 10000, 0.03m);
            var s4 = new Loan (CustomerType.Company, Date2, 30, 0.04m);
            var s5 = new Deposit(CustomerType.Individual, Date2, 900, 0.02m);
            var s6 = new Mortgage(CustomerType.Individual, Date2, 100, 0.02m);

            // Testing deposit's WithDraw()
            Console.WriteLine("Deposit balance befeore WithDraw: "+s2.Balance);
            s2.WithDraw(60);
            Console.WriteLine("Deposit balance after WithDraw(60): "+ s2.Balance);
            Console.WriteLine();

            List<IAccount> accountList = new List<IAccount> { s1, s2, s3, s4, s5, s6 };

            foreach (var account in accountList)
            {
                Console.WriteLine("{0} with balance: {1} and Interest Amount: {2}",account.GetType().Name , account.Balance, account.CalculateInterestAmount(now));
            }


 
        }
    }
}
