using System;
using System.Text.RegularExpressions;

class ValidateLicenceNumber
{
    static void Main()
    {
        string[] plates = { "AB1234", "A12345", "ab1234" };

        foreach (string plate in plates)
        {
            if (IsValidPlate(plate))
                Console.WriteLine($"{plate} → Valid");
            else
                Console.WriteLine($"{plate} → Invalid");
        }
    }

    static bool IsValidPlate(string plate)
    {
        string pattern = @"^[A-Z]{2}[0-9]{4}$";
        return Regex.IsMatch(plate, pattern);
    }
}
