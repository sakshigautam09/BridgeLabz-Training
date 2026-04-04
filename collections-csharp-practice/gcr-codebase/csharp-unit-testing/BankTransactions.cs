using System;
using NUnit.Framework;

// --------------------- BankAccount Class ---------------------
public class BankTransactions
{
    private double balance;

    // Deposit money into account
    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative.");
        }
        balance += amount;
    }

    // Withdraw money from account
    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative.");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        balance -= amount;
    }

    // Get current balance
    public double GetBalance()
    {
        return balance;
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class BankAccountTests
{
    private BankAccount account;

    [SetUp]
    public void Setup()
    {
        account = new BankAccount();
    }

    [Test]
    public void Deposit_AddsAmountToBalance()
    {
        account.Deposit(100.0);
        account.Deposit(50.0);

        Assert.AreEqual(150.0, account.GetBalance());
    }

    [Test]
    public void Withdraw_SubtractsAmountFromBalance()
    {
        account.Deposit(200.0);
        account.Withdraw(50.0);

        Assert.AreEqual(150.0, account.GetBalance());
    }

    [Test]
    public void Withdraw_InsufficientFunds_ThrowsException()
    {
        account.Deposit(100.0);

        Assert.Throws<InvalidOperationException>(() => account.Withdraw(150.0));
    }

    [Test]
    public void Deposit_NegativeAmount_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => account.Deposit(-50.0));
    }

    [Test]
    public void Withdraw_NegativeAmount_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => account.Withdraw(-30.0));
    }
}
