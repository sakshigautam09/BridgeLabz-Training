using System;

public class CurrentAccount : BankAccount, ILoanable
{
    private double overdraftLimit;

    public CurrentAccount(string accountNumber, string holderName, double balance, double overdraftLimit)
        : base(accountNumber, holderName, balance)
    {
        this.overdraftLimit = overdraftLimit;
    }

    public override double CalculateInterest()
    {
        return Balance * 0.01;
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine("Loan of " + amount + " applied for Current Account: " + AccountNumber);
    }

    public double CalculateLoanEligibility()
    {
        return Balance + overdraftLimit;
    }
}
