// ================= UC-2 =================
// Service eligibility logic
// Nested if-else + switch
// ========================================

using System;

public class EligibilityPackage
{
    // ================= EXISTING UC-2 METHOD (DO NOT MODIFY) =================
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


    // ================= ADDITION (BACKWARD COMPATIBILITY) =================
    // Supports older UC calls using primitive values
    public string DeterminePackage(int age, double income, int residencyYears)
    {
        FamilyMember temp = new FamilyMember("Primary", age, income, residencyYears);
        return DeterminePackage(temp);
    }


    // ================= EXISTING UC-2 SWITCH METHOD =================
    public void ShowBenefits(string package)
    {
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
