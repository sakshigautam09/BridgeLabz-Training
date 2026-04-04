using System;
using System.Text.RegularExpressions;

class ExtractCurrency   
{
    static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";

        string pattern = @"\$\s*(\d+\.\d+)";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            // If space exists after $, print only number; else print full value
            if (match.Value.Contains(" "))
                Console.WriteLine(match.Groups[1].Value);
            else
                Console.WriteLine(match.Value);
        }
    }
}
