using System;
using System.Text.RegularExpressions;

class ValidateHexCode
{
    static void Main()
    {
        string[] colors = { "#FFA500", "#ff4500", "#123" };

        foreach (string color in colors)
        {
            if (IsValidHexColor(color))
                Console.WriteLine($"{color} → Valid");
            else
                Console.WriteLine($"{color} → Invalid");
        }
    }

    static bool IsValidHexColor(string color)
    {
        string pattern = @"^#[0-9A-Fa-f]{6}$";
        return Regex.IsMatch(color, pattern);
    }
}
