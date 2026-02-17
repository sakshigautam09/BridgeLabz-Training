using System;

namespace TechVille
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen = new Citizen();

            Console.WriteLine("=== TechVille Citizen Registration Portal ===");

            // Accept citizen details
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
                Console.WriteLine("\nInvalid data entered. Please restart registration.");
                return;
            }

            // Calculate eligibility score using arithmetic operators
            double eligibilityScore = (citizen.Age * 0.5) + (citizen.ResidencyYears * 2) + (citizen.Income / 10000);

            // Display formatted information
            Console.WriteLine("\n=== Citizen Information ===");
            Console.WriteLine("Name: " + citizen.Name);
            Console.WriteLine("Age: " + citizen.Age);
            Console.WriteLine("Income: " + citizen.Income);
            Console.WriteLine("Residency Years: " + citizen.ResidencyYears);
            Console.WriteLine("Service Eligibility Score: " + eligibilityScore);

            Console.WriteLine("\nRegistration Completed.");
        }
    }
}
