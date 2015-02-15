using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Deposit : Account
    {
        public Deposit (CustomerType theCustomer, DateTime created, decimal balance, decimal interestRate)
            :base(theCustomer,created ,balance, interestRate )
        {

        }

        public void WithDraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(DateTime date)
        {
            // Deposit accounts have no interest if their balance is positive and less than 1000.

            if (this.Balance>0 && this.Balance<1000)
            {
                return 0;
            }
            else
            {
                //Calculate the monts between date of creation and the given date and * interest_rate
                return this.InterestRate*((date.Year - this.CreatedDate.Year) * 12 + date.Month - this.CreatedDate.Month);
            }
        }
    }
}
