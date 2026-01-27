using System;
using System.Text.RegularExpressions;

class ValidateSSN
{
    static void Main()
    {
        string[] inputs = { "123-45-6789", "123456789" };

        foreach (string ssn in inputs)
        {
            if (IsValidSSN(ssn))
                Console.WriteLine($"\"{ssn}\" is valid");
            else
                Console.WriteLine($"\"{ssn}\" is invalid");
        }
    }

    static bool IsValidSSN(string ssn)
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        return Regex.IsMatch(ssn, pattern);
    }
}
