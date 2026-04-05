using System;

public class Program
{
    public static void Main()
    {
        ErrorLogger logger = new ErrorLogger();

        try
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("      TECHVILLE SMART CITY SYSTEM");
            Console.WriteLine("==========================================\n");

            // ================= UC-1 =================
            Console.WriteLine("STEP 1: CITIZEN REGISTRATION\n");

            Console.Write("Enter Citizen ID: ");
            int citizenId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 0 || age > 120)
                throw new InvalidAgeException("Age must be between 1 and 120.");

            Console.Write("Enter Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Residency Years: ");
            int residencyYears = Convert.ToInt32(Console.ReadLine());

            Citizen citizen = new Citizen(citizenId, name, age, income, residencyYears);

            Console.WriteLine("\nCitizen Registered Successfully!\n");

            // ================= UC-2 =================
            Console.WriteLine("STEP 2: SERVICE ELIGIBILITY & FAMILY DETAILS\n");

            EligibilityPackage package = new EligibilityPackage();

            FamilyMember primaryMember = new FamilyMember(name, age, income, residencyYears);
            string servicePackage = package.DeterminePackage(primaryMember);

            Console.WriteLine("Assigned Service Package: " + servicePackage);

            Console.Write("\nEnter number of family members: ");
            int familyCount = Convert.ToInt32(Console.ReadLine());

            FamilyMember[] members = new FamilyMember[familyCount];

            for (int i = 0; i < familyCount; i++)
            {
                Console.WriteLine("\nFamily Member " + (i + 1));

                Console.Write("Name: ");
                string fname = Console.ReadLine();

                Console.Write("Age: ");
                int fage = Convert.ToInt32(Console.ReadLine());

                members[i] = new FamilyMember(fname, fage);
            }

            string status = age > 60 ? "Senior Citizen Benefits" : "Standard Benefits";
            Console.WriteLine("\nBenefit Status: " + status);

            // ================= UC-6 =================
            Console.WriteLine("\nSTEP 6: CITY SERVICES FRAMEWORK\n");

            Console.Write("Enter Healthcare service budget: ");
            double healthCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter available doctors: ");
            int doctors = Convert.ToInt32(Console.ReadLine());

            HealthcareService healthcare = new HealthcareService(healthCost, doctors);

            Console.Write("\nEnter Education service budget: ");
            double eduCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter available schools: ");
            int schools = Convert.ToInt32(Console.ReadLine());

            EducationService education = new EducationService(eduCost, schools);

            healthcare.ShowHealthcareDetails();
            education.ShowEducationDetails();

            // ================= UC-7 =================
            Console.WriteLine("\nSTEP 7: ADVANCED SERVICE ARCHITECTURE");

            Console.WriteLine("Total services before creation: " + Service.TotalServices);

            Console.Write("\nEnter premium healthcare cost: ");
            double phCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter doctors: ");
            int phDoctors = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter premium facility: ");
            string phFeature = Console.ReadLine();

            PremiumHealthcareService premiumHealth =
                new PremiumHealthcareService(phCost, phDoctors, phFeature);

            premiumHealth.ShowPremiumHealthcare();

            Console.Write("\nEnter premium education cost: ");
            double peCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter schools: ");
            int peSchools = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter smart feature: ");
            string peFeature = Console.ReadLine();

            PremiumEducationService premiumEdu =
                new PremiumEducationService(peCost, peSchools, peFeature);

            premiumEdu.ShowPremiumEducation();

            Console.WriteLine("Total services created: " + Service.TotalServices);
        }
        catch (Exception ex)
        {
            Console.WriteLine("System error occurred.");
            logger.LogError(ex.Message);
        }
        finally
        {
            Console.WriteLine("\nExecution completed safely.");
        }
    }
}
