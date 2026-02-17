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

            // ================= UC-3 =================
            Console.WriteLine("\nSTEP 3: SMART CITY DATABASE STORAGE\n");

            Console.Write("How many citizen IDs to store? ");
            int size = Convert.ToInt32(Console.ReadLine());

            CitizenDatabase db = new CitizenDatabase(size);

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Citizen ID: ");
                db.AddCitizenId(Convert.ToInt32(Console.ReadLine()));
            }

            db.DisplayCitizenIds();

            // ================= UC-4 =================
            Console.WriteLine("\nSTEP 4: CITIZEN PROFILE MANAGEMENT\n");

            StringUtilities stringUtils = new StringUtilities();
            CitizenProfileManager profileManager = new CitizenProfileManager();
            ProfileGenerator generator = new ProfileGenerator();

            Console.Write("\nEnter name to format: ");
            string rawName = Console.ReadLine();
            Console.WriteLine("Formatted Name: " + stringUtils.FormatName(rawName));

            Console.Write("\nEnter email to validate: ");
            string email = Console.ReadLine();
            Console.WriteLine(stringUtils.ValidateEmail(email) ? "Valid Email" : "Invalid Email");

            Console.Write("\nEnter income to update (pass-by-value demo): ");
            double inc = Convert.ToDouble(Console.ReadLine());
            profileManager.UpdateIncome(inc);

            Console.Write("\nEnter name for reference update (pass-by-ref demo): ");
            string refName = Console.ReadLine();
            profileManager.UpdateCitizenName(ref refName);
            Console.WriteLine("Updated Name: " + refName);

            Console.WriteLine("\nGenerating citizen profile...");
            generator.GenerateProfile();
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nSystem error occurred.");
            logger.LogError(ex.Message);
        }
        finally
        {
            Console.WriteLine("\nExecution completed safely.");
        }
    }
}
