using System;
class AnagramStrings
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        if (CheckAnagrams(s1, s2))
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }
    static bool CheckAnagrams(string s1, string s2)
    {
        int[] freq = new int[256];
        foreach (char c in s1)
            freq[c]++;
        foreach (char c in s2)
        {
            freq[c]--;
            if (freq[c] < 0)
                return false;
        }
        return true;
    }
}