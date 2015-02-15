using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Loan : Account
    {
        public Loan (CustomerType theCustomer, DateTime created, decimal balance, decimal interestRate)
            :base(theCustomer,created ,balance, interestRate )
        {

        }

        public override decimal CalculateInterestAmount(DateTime date)
        {
            // Loan accounts have no interest for the first 3 months if are held by individuals 
            // and for the first 2 months if are held by a company.

            int monts = (date.Year - this.CreatedDate.Year) * 12 + date.Month - this.CreatedDate.Month;
            if (this.Customer == CustomerType.Individual )
            {
                if (monts>3)
                {
                    return this.InterestRate *(monts -3);
                }
                else
                {
                    return 0;
                }
                
            }
            else
            {
                if (monts>2)
                {
                    return this.InterestRate * monts;
                }
                else
                {
                    return 0;
                }
                
            }
        }
    }
}
