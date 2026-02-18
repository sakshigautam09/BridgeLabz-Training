// ======================================
// UC-4: Profile update + search
// Pass by value & reference
// ======================================

using System;

public class CitizenProfileManager
{
    // Pass-by-value example
    public void UpdateIncome(double income)
    {
        income += 5000;
        Console.WriteLine("Updated Income (inside method): " + income);
    }

    // Pass-by-reference example
    public void UpdateCitizenName(ref string name)
    {
        name = name + " (Updated)";
    }

    // Search citizen using string match
    public void SearchCitizenByName(string[] names, string searchName)
    {
        bool found = false;

        foreach (string name in names)
        {
            if (name != null && name.ToLower().Contains(searchName.ToLower()))
            {
                Console.WriteLine("Citizen Found: " + name);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("Citizen not found.");
    }
}
