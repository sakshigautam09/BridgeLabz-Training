using System;

class Program
{
    static void Main(string[] args)
    {

        // ================= UC-1 =================
        // Citizen Registration
        // Basic input, validation, eligibility score
        // ========================================

        Citizen citizen = new Citizen();

        Console.WriteLine("=== TechVille Citizen Registration Portal ===");

        Console.Write("Enter Name: ");
        citizen.Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        citizen.Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Annual Income: ");
        citizen.Income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Residency Years: ");
        citizen.ResidencyYears = Convert.ToInt32(Console.ReadLine());

        // Basic validation using comparison operators
        if (citizen.Age <= 0 || citizen.Income < 0 || citizen.ResidencyYears < 0)
        {
            Console.WriteLine("\nInvalid data entered.");
            return;
        }

        // Eligibility score calculation using arithmetic operators
        double eligibilityScore = (citizen.Age * 0.5) +
                                  (citizen.ResidencyYears * 2) +
                                  (citizen.Income / 10000);

        Console.WriteLine("\n=== Citizen Information ===");
        Console.WriteLine("Name: " + citizen.Name);
        Console.WriteLine("Eligibility Score: " + eligibilityScore);



        // ================= UC-2 =================
        // Service Eligibility Checker
        // Loops, nested if-else, switch, ternary, break, continue
        // Multiple family members using array
        // ========================================

        Console.Write("\nEnter number of family members: ");
        int count = Convert.ToInt32(Console.ReadLine());

        FamilyMember[] members = new FamilyMember[count];
        EligibilityPackage checker = new EligibilityPackage();

        // for loop
        for (int i = 0; i < count; i++)
        {
            members[i] = new FamilyMember();

            Console.WriteLine($"\nEnter details for member {i + 1}");

            Console.Write("Name: ");
            members[i].Name = Console.ReadLine();

            // while loop + break/continue validation
            while (true)
            {
                Console.Write("Age: ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Invalid age. Try again.");
                    continue;
                }

                if (age <= 0)
                {
                    Console.WriteLine("Age must be positive.");
                    continue;
                }

                members[i].Age = age;
                break;
            }

            Console.Write("Income: ");
            members[i].Income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Residency Years: ");
            members[i].ResidencyYears = Convert.ToInt32(Console.ReadLine());

            // Nested if-else used inside method
            members[i].Package = checker.DeterminePackage(members[i]);

            // ternary operator
            string status = members[i].Income > 300000
                ? "Eligible Citizen"
                : "Needs Financial Support";

            Console.WriteLine("Status: " + status);
            Console.WriteLine("Assigned Package: " + members[i].Package);

            // switch
            checker.ShowBenefits(members[i].Package);
        }

        // foreach loop
        Console.WriteLine("\n=== Family Members Summary ===");

        foreach (var m in members)
        {
            Console.WriteLine($"{m.Name} | Age: {m.Age} | Package: {m.Package}");
        }

        Console.ReadKey();
    }
}
