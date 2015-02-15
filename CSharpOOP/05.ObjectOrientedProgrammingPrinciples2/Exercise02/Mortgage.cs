using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Mortgage :Account
    {
        public Mortgage (CustomerType theCustomer, DateTime created, decimal balance, decimal interestRate)
            :base(theCustomer,created ,balance, interestRate )
        {

        }

        public override decimal CalculateInterestAmount(DateTime date)
        {
            // Mortgage accounts have ½ interest for the first 12 months for companies 
            // and no interest for the first 6 months for individuals.

            int monts = (date.Year - this.CreatedDate.Year) * 12 + date.Month - this.CreatedDate.Month;

            if (this.Customer == CustomerType.Individual)
            {
                if (monts > 6)
                {
                    return this.InterestRate * (monts-6);
                }
                else
                {
                    return 0;
                }

            }
            else
            {
                if (monts > 12)
                {
                    return (this.InterestRate * (monts - 12)) + (this.InterestRate*6);
                }
                else 
                {
                    return (this.InterestRate * (monts / 2));
                }
            }                                    
        }
    }
}
