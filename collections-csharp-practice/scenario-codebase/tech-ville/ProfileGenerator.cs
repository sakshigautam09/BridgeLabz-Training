// ======================================
// UC-4: Profile generator
// Multiple helper functions
// ======================================

using System;

public class ProfileGenerator
{
    StringUtilities utils = new StringUtilities();

    public void GenerateProfile()
    {
        Console.Write("\nEnter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        name = utils.FormatName(name);

        if (!utils.ValidateEmail(email))
        {
            Console.WriteLine("Invalid Email Format!");
            return;
        }

        address = utils.ParseAddress(address);

        Console.WriteLine("\nGenerated Profile:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Address: " + address);
    }
}
