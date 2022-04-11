using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class DepositAcct : Individual, Deposit, Withdrawal
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

        public decimal IcalcInterestRate(decimal months, decimal interest, decimal acctBal)
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

        public DepositAcct(Account dptAcct)
        {

            Console.WriteLine("\n\nWhich action would you like to perform");
            Console.WriteLine("1.\tDeposit");
            Console.WriteLine("2.\tWithdraw");
            Console.WriteLine("2.\tCalculate Interest Rate");
            Console.Write("\nYour choice is: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.Write("\n\nEnter the amount you'd like to deposit: ");
                    decimal depositAmt = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nYour new account balance is {0}", deposit(dptAcct.acctBal, depositAmt));
                    break;

                case 2:

                    Console.Write("\n\nEnter the amount you'd like to Withdraw: ");
                    decimal wDrawAmt = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nYour new account balance is {0}", withdraw(dptAcct.acctBal, wDrawAmt));
                    break;


                case 3:

                    Console.Write("\n\nEnter the number of months: ");
                    decimal months = decimal.Parse(Console.ReadLine());

                    decimal rate = IcalcInterestRate(months, dptAcct.monthlyInterest, dptAcct.acctBal);
                    Console.WriteLine("\nThe accumulated interest is {0}", rate);


                    break;

                default:
                    Console.WriteLine("\nInvalid Choice");
                    break;
            }
        }
    }
}

