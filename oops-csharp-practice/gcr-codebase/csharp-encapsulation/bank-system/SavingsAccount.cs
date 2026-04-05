using System;
public class SavingsAccount : BankAccount, ILoanable
{
    private double interestRate;

    public SavingsAccount(string accountNumber, string holderName, double balance, double interestRate)
        : base(accountNumber, holderName, balance)
    {
        this.interestRate = interestRate;
    }

    public override double CalculateInterest()
    {
        return Balance * interestRate / 100;
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine("Loan of " + amount + " applied for Savings Account: " + AccountNumber);
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 0.5;
    }
}
