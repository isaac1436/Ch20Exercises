namespace Bank
{
    public interface Individual
    {
        public decimal calcInterestRate(decimal months, decimal interest, decimal acctBal);
    }

    public interface Company
    {
        public decimal calcInterestRate(decimal months, decimal interest, decimal acctBal);
    }

    public interface Deposit
    {
        decimal deposit(decimal acctBal, decimal deposit);
    }

    public interface Withdrawal
    {
        decimal withdraw(decimal acctBal, decimal wdrawAmt );
    }
    public abstract class Account
    {
        public decimal acctBal;
        public decimal monthlyInterest;

    }

}