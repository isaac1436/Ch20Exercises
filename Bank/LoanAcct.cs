
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class LoanAcct : Account, Deposit, Individual, Company
    {
        public decimal deposit(decimal acctBal, decimal deposit)
        {
            acctBal = acctBal + deposit;
            return acctBal;
        }
        decimal Individual.calcInterestRate(decimal months, decimal interest, decimal acctBal)
        {
            decimal rate;

            if (months <= 3)
            {
                rate = 0;
                return rate;
            }

            else
            {
                rate = interest * months;
                return rate;
            }
        }

        decimal Company.calcInterestRate(decimal months, decimal interest, decimal acctBal)
        {
            decimal rate;
            if (months <= 2)
            {
                rate = 0;
                return rate;
            }

            else
            {
                rate = interest * months;
                return rate;
            }
        }

        public LoanAcct()
        {

        }
    }
}
