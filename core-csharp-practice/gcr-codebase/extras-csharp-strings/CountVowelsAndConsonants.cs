using System;
class CountVowelsAndConsonants
{
    static void Main()
    {
        string s = Console.ReadLine();
        int vowelCount = 0;
        int consonantCount = 0;
        foreach (char c in s.ToLower())
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".Contains(c))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }
        Console.WriteLine($"Vowels: {vowelCount}");
        Console.WriteLine($"Consonants: {consonantCount}");
    }
}