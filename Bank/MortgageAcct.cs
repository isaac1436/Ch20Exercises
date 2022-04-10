using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class MortgageAcct : Account, Deposit, Individual, Company
    {
        public decimal deposit(decimal acctBal, decimal deposit)
        {
            acctBal = acctBal + deposit;
            return acctBal;
        }

        decimal Company.calcInterestRate(decimal months, decimal interest, decimal acctBal)
        {
            decimal rate;
            if (months <= 12)
            {
                rate = (interest * months) / 2;
                return rate;
            }

            else
            {
                rate = interest * months;
                return rate;
            }
        }

        decimal Individual.calcInterestRate(decimal months, decimal interest, decimal acctBal)
        {
            decimal rate;
            if (months <= 6)
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
    }
}
