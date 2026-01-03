using System;
class BankAccount
{
    // static variable (shared by all accounts)
    public static string bankName = "State Bank of India";
    private static int totalAccounts = 0;

    // readonly variable
    public readonly int AccountNumber;

    // instance variable
    public string AccountHolderName;

    // Constructor using 'this'
    public BankAccount(int accountNumber, string accountHolderName)
    {
        this.AccountNumber = accountNumber;          // readonly assigned once
        this.AccountHolderName = accountHolderName;  // resolves ambiguity
        totalAccounts++;
    }

    // static method
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts Created: " + totalAccounts);
    }

    // Instance method
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Holder: " + AccountHolderName);
    }
}
class BankAccountSystem
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount(101, "Rahul");
        BankAccount acc2 = new BankAccount(102, "Neha");

        Console.WriteLine();

        // Using 'is' operator
        if (acc1 is BankAccount)
        {
            Console.WriteLine("acc1 is a BankAccount object");
            acc1.DisplayAccountDetails();
        }

        Console.WriteLine();

        if (acc2 is BankAccount)
        {
            Console.WriteLine("acc2 is a BankAccount object");
            acc2.DisplayAccountDetails();
        }

        Console.WriteLine();

        // Static method call
        BankAccount.GetTotalAccounts();
    }
}
