using System;

class PasswordCrackerSimultor
{
    static bool found = false; // Scenario B: stop if password matched

    static void Main()
    {
        char[] charset = { 'a', 'b', 'c' }; // allowed characters
        int n = 3; // password length
        string targetPassword = "bac";

        Console.WriteLine("Scenario A: All possible combinations:");
        Generate("", charset, n, targetPassword);

        if (!found)
            Console.WriteLine("\nPassword not found.");
    }

    // Backtracking function
    static void Generate(string current, char[] charset, int n, string target)
    {
        if (found) return; // Scenario B: stop if password matched

        if (current.Length == n)
        {
            Console.WriteLine(current); // Scenario A: print combination

            if (current == target)
            {
                Console.WriteLine($"\nScenario B: Password '{target}' cracked!");
                found = true;
            }
            return;
        }

        // Try each character at current position
        foreach (char c in charset)
        {
            Generate(current + c, charset, n, target);
        }
    }
}
