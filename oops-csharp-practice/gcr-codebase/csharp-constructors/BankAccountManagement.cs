using System;
class BankAccount
{
    public string accountNumber;       // public
    protected string accountHolder;    // protected
    private double balance;            // private

    // Constructor
    public BankAccount(string accNo, string holder, double bal)
    {
        accountNumber = accNo;
        accountHolder = holder;
        balance = bal;
    }

    // Public methods to access private member
    public void Deposit(double amt)
    {
        balance += amt;
    }

    public void Withdraw(double amt)
    {
        if (amt <= balance)
            balance -= amt;
        else
            Console.WriteLine("Insufficient balance");
    }

    public double GetBalance()
    {
        return balance;
    }

    public void DisplayAccount()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: ₹" + balance);
    }
}

// Subclass 
class SavingsAccount : BankAccount
{
    public double interestRate;

    public SavingsAccount(string accNo, string holder, double bal, double rate)
        : base(accNo, holder, bal)
    {
        interestRate = rate;
    }

    public void DisplaySavingsAccount()
    {
        Console.WriteLine("Account Number: " + accountNumber);     // public
        Console.WriteLine("Account Holder: " + accountHolder);     // protected
        Console.WriteLine("Interest Rate: " + interestRate + "%");
        Console.WriteLine("Balance: ₹" + GetBalance());           // private via public method
    }
}
class BankApp
{
    static void Main()
    {
        BankAccount ba = new BankAccount("ACC101", "Rahul", 5000);
        ba.DisplayAccount();

        Console.WriteLine();

        SavingsAccount sa = new SavingsAccount("ACC102", "Neha", 10000, 5);
        sa.DisplaySavingsAccount();
    }
}
