using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class DepositAcct : Account, Individual,Deposit,Withdrawal
    {
        public decimal deposit(decimal acctBal, decimal deposit)
        {
            acctBal = acctBal + deposit;
            return acctBal;
        }

        public decimal withdraw(decimal acctBal, decimal wdrawAmt)
        {
            acctBal = acctBal - wdrawAmt;
            return acctBal;
        }

        public decimal calcInterestRate(decimal months, decimal interest, decimal acctBal)
        {
            decimal rate;
            if (acctBal > 0 && acctBal < 1000)
            {
                rate = 0;
                return rate;
            }

            else
            {
                rate = months * interest;
                return rate;
            }
        }

    }
}

