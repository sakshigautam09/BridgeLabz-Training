using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== TECHVILLE SMART CITY SYSTEM =====");

        // ================= UC-1 =================
        // Citizen basic registration
        // ========================================

        Console.Write("Enter Citizen ID: ");
        int citizenId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Residency Years: ");
        int residencyYears = Convert.ToInt32(Console.ReadLine());

        Citizen citizen = new Citizen(citizenId, name, age, income, residencyYears);

        double eligibilityScore = (age * 0.3) + (income * 0.2) + (residencyYears * 0.5);

        Console.WriteLine("\nCitizen Registered Successfully!");
        Console.WriteLine($"Eligibility Score: {eligibilityScore}");

        // ================= UC-2 =================
        // Service eligibility + family members
        // ========================================

        EligibilityPackage package = new EligibilityPackage();
        string servicePackage = package.DeterminePackage(age, income, residencyYears);

        Console.WriteLine($"Service Package: {servicePackage}");

        // Multiple family members registration
        Console.Write("\nEnter number of family members: ");
        int familyCount = Convert.ToInt32(Console.ReadLine());

        FamilyMember[] members = new FamilyMember[familyCount];

        for (int i = 0; i < familyCount; i++)
        {
            Console.WriteLine($"\nEnter details for Family Member {i + 1}");

            Console.Write("Name: ");
            string fname = Console.ReadLine();

            Console.Write("Age: ");
            int fage = Convert.ToInt32(Console.ReadLine());

            if (fage <= 0)
            {
                Console.WriteLine("Invalid age! Skipping...");
                continue;
            }

            members[i] = new FamilyMember(fname, fage);
        }

        // Ternary operator
        string status = age > 60 ? "Senior Citizen Benefits" : "Standard Benefits";
        Console.WriteLine($"Benefit Status: {status}");

        // ================= UC-3 =================
        // Smart Citizen Database using Arrays
        // ========================================

        Console.Write("\nEnter number of citizens to store in database: ");
        int size = Convert.ToInt32(Console.ReadLine());

        CitizenDatabase db = new CitizenDatabase(size);

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter Citizen ID {i + 1}: ");
            int id = Convert.ToInt32(Console.ReadLine());
            db.AddCitizenId(id);
        }

        db.DisplayCitizenIds();

        // Zone sector updates
        Console.Write("\nHow many zone updates? ");
        int updates = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < updates; i++)
        {
            Console.Write("Enter Zone (0-4): ");
            int zone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sector (0-3): ");
            int sector = Convert.ToInt32(Console.ReadLine());

            db.UpdateZoneSector(zone, sector);
        }

        db.DisplayZoneSectorData();

        // Array operations
        ArrayOperations ops = new ArrayOperations();
        int[] ids = db.GetCitizenIds();

        ops.SortIds(ids);

        Console.WriteLine("\nSorted Citizen IDs:");
        foreach (int id in ids)
            Console.Write(id + " ");

        Console.Write("\nEnter ID to search: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        bool found = ops.SearchId(ids, searchId);
        Console.WriteLine(found ? "Citizen Found" : "Citizen Not Found");

        int[] copied = ops.CopyArray(ids);

        Console.WriteLine("\nCopied Array:");
        foreach (int id in copied)
            Console.Write(id + " ");
    }
}
