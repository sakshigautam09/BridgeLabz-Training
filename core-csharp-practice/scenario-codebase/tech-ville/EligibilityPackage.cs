// ================= UC-2 =================
// Service eligibility logic
// Nested if-else + switch
// ========================================

using System;

public class EligibilityPackage
{
    public string DeterminePackage(FamilyMember member)
    {
        string package = "Basic";

        // Nested if-else eligibility logic
        if (member.Income > 1000000)
        {
            if (member.ResidencyYears > 10)
                package = "Platinum";
            else
                package = "Gold";
        }
        else if (member.Income > 500000)
        {
            package = "Silver";
        }
        else
        {
            package = "Basic";
        }

        return package;
    }

    public void ShowBenefits(string package)
    {
        // switch statement
        switch (package)
        {
            case "Basic":
                Console.WriteLine("Basic: Limited city services.");
                break;

            case "Silver":
                Console.WriteLine("Silver: Healthcare + Education.");
                break;

            case "Gold":
                Console.WriteLine("Gold: Housing priority.");
                break;

            case "Platinum":
                Console.WriteLine("Platinum: Premium smart city services.");
                break;

            default:
                Console.WriteLine("Invalid package.");
                break;
        }
    }
}
