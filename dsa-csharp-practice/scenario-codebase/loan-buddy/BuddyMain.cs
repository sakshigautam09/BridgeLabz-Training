using System;
class BuddyMain
{
    static void Main()
    {
        Console.WriteLine("===== Loan Approval System =====\n");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Credit Score: ");
        int creditScore = int.Parse(Console.ReadLine());

        Console.Write("Enter Monthly Income: ");
        double income = double.Parse(Console.ReadLine());

        Console.Write("Enter Loan Amount: ");
        double amount = double.Parse(Console.ReadLine());

        Applicant applicant = new Applicant(name, creditScore, income, amount);

        Console.WriteLine("\nSelect Loan Type:");
        Console.WriteLine("1. Personal Loan");
        Console.WriteLine("2. Home Loan");
        Console.WriteLine("3. Auto Loan");
        Console.Write("Choice: ");

        int chooseOption = int.Parse(Console.ReadLine());

        // Upcasting + Polymorphism
        LoanApplication loan = null;

        switch (chooseOption)
        {
            case 1:
                loan = new PersonalLoan(36, 12);
                break;
            case 2:
                loan = new HomeLoan(240, 8.5);
                break;
            case 3:
                loan = new AutoLoan(60, 9);
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        Console.WriteLine("\nProcessing loan...\n");

        if (loan.ApproveLoan(applicant))
        {
            Console.WriteLine("Loan Approved");
            Console.WriteLine($"Monthly EMI: {loan.CalculateEMI(applicant):F2}");
        }
        else
        {
            Console.WriteLine("❌ Loan Rejected");
        }

        Console.WriteLine("\nThank you for using LoanBuddy!");
    }
}