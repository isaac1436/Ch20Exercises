using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class MortgageAcct : Deposit, Individual, Company
    {
        public decimal deposit(decimal acctBal, decimal deposit)
        {
            acctBal = acctBal + deposit;
            return acctBal;
        }

        public decimal CcalcInterestRate(decimal months, decimal interest, decimal acctBal)
        {
            decimal rate;
            if (months <= 12)
            {
                rate = (interest * months) / 2;
                return rate;
            }

            else
            {
                rate = interest * (months-12);
                return rate;
            }
        }

        public decimal IcalcInterestRate(decimal months, decimal interest, decimal acctBal)
        {
            decimal rate;
            if (months <= 6)
            {
                rate = 0;
                return rate;
            }

            else
            {
                rate = interest * (months-6);
                return rate;
            }
        }

        public MortgageAcct(Account MgageAcct)
        {

            Console.WriteLine("\n\nWhich action would you like to perform");
            Console.WriteLine("1.\tDeposit");
            Console.WriteLine("2.\tCalculate Interest Rate");
            Console.Write("\nYour choice is: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.Write("\n\nEnter the amount you'd like to deposit: ");
                    decimal depositAmt = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nYour new account balance is {0}", deposit(MgageAcct.acctBal, depositAmt));
                    break;

                case 2:

                    Console.Write("\n\nEnter the number of months: ");
                    decimal months = decimal.Parse(Console.ReadLine());

                    Console.Write("\nAre you an individual(1) or company(2): ");
                    int choice2 = int.Parse(Console.ReadLine());

                    if (choice2 == 1)
                    {

                        decimal rate = IcalcInterestRate(months, MgageAcct.monthlyInterest, MgageAcct.acctBal);
                        Console.WriteLine("\nThe accumulated interest is {0}", rate);
                    }

                    else if (choice2 == 2)
                    {

                        decimal rate = CcalcInterestRate(months, MgageAcct.monthlyInterest, MgageAcct.acctBal);
                        Console.WriteLine("\nThe accumulated interest is {0}", rate);
                    }

                    else { Console.WriteLine("\nInvalid Choice"); }

                    break;

                default:
                    Console.WriteLine("\nInvalid Choice");
                    break;
            }
        }
    }
}
