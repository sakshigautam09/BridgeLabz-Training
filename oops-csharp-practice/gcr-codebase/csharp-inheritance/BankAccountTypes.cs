using System;
class BankAccount
{
    public int AccountNumber;
    public double Balance;

    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: ₹" + Balance);
    }
}

class SavingsAccount : BankAccount
{
    public double InterestRate;

    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Savings Account");
        DisplayBasicInfo();
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

class CheckingAccount : BankAccount
{
    public double WithdrawalLimit;

    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Checking Account");
        DisplayBasicInfo();
        Console.WriteLine("Withdrawal Limit: ₹" + WithdrawalLimit);
    }
}

class FixedDepositAccount : BankAccount
{
    public int MaturityPeriod; // in months

    public FixedDepositAccount(int accountNumber, double balance, int maturityPeriod)
        : base(accountNumber, balance)
    {
        MaturityPeriod = maturityPeriod;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Fixed Deposit Account");
        DisplayBasicInfo();
        Console.WriteLine("Maturity Period: " + MaturityPeriod + " months");
    }
}

class BankAccountTypes
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(101, 50000, 4.5);
        CheckingAccount ca = new CheckingAccount(102, 30000, 10000);
        FixedDepositAccount fda = new FixedDepositAccount(103, 100000, 24);

        sa.DisplayAccountType();
        Console.WriteLine();

        ca.DisplayAccountType();
        Console.WriteLine();

        fda.DisplayAccountType();
    }
}
