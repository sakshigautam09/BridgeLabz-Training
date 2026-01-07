using System;
class Program
{
    static void Main()
    {
        BankAccount[] accounts = new BankAccount[4];

        SavingsAccount acc1 = new SavingsAccount("SAV101", "sakshi", 50000, 5);
        CurrentAccount acc2 = new CurrentAccount("CUR201", "gautam", 20000, 10000);
        SavingsAccount acc3 = new SavingsAccount("SAV102", "vishwas", 30000, 4.5);
        CurrentAccount acc4 = new CurrentAccount("CUR202", "gautam", 40000, 15000);

        accounts[0] = acc1;
        accounts[1] = acc2;
        accounts[2] = acc3;
        accounts[3] = acc4;

        Console.WriteLine("=== Banking System ===");

        for (int i = 0; i < accounts.Length; i++)
        {
            accounts[i].DisplayDetails();

            double interest = accounts[i].CalculateInterest();
            Console.WriteLine("Calculated Interest: " + interest);

            ILoanable loanable = accounts[i] as ILoanable;
            if (loanable != null)
            {
                double eligibility = loanable.CalculateLoanEligibility();
                Console.WriteLine("Loan Eligibility: " + eligibility);
            }
        }
        accounts[0].Deposit(5000);
        accounts[1].Withdraw(3000);
    }
}
