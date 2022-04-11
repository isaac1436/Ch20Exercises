namespace Bank
{
    public interface Individual
    {
        decimal IcalcInterestRate(decimal months, decimal interest, decimal acctBal);
    }

    public interface Company
    {
        decimal CcalcInterestRate(decimal months, decimal interest, decimal acctBal);
    }

    public interface Deposit
    {
        decimal deposit(decimal acctBal, decimal deposit);
    }

    public interface Withdrawal
    {
        decimal withdraw(decimal acctBal, decimal wdrawAmt );
    }
    public class Account
    {
        public decimal acctBal;
        public decimal monthlyInterest;

        public Account(decimal acctBal,decimal Interest)
        {
            this.acctBal = acctBal;
            this.monthlyInterest = Interest;
        }

        static void Main()
        {
            Console.Write("Firstly, please enter your account balance: $");

            decimal acctBal = decimal.Parse(Console.ReadLine());


            Console.Write("\nEnter the Current Interest Rate: $");
            decimal monthlyInterest = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat type of Account do you own");
            Console.WriteLine("1.\tDeposit Account");
            Console.WriteLine("2.\tMortgage Account");
            Console.WriteLine("3.\tLoan Account");

            Console.Write("\nEnter the corresponding digit: ");
            int choice=int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Account dptAcct = new Account(acctBal,monthlyInterest);
                    DepositAcct DptAcct = new DepositAcct(dptAcct);
                    break;

                case 2:
                    Account MgageAcct = new Account(acctBal, monthlyInterest);
                    new MortgageAcct(MgageAcct);
                    break;

                case 3:
                    Account lAcct = new Account(acctBal, monthlyInterest);
                    new LoanAcct(lAcct);
                    break;

                default:
                    Console.WriteLine("\nInvalid Choice");
                    break;
            }

        }

    }

}