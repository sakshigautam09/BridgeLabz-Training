using System;
class FindSubstringOccurances
{
    static void Main()
    {
        string s = Console.ReadLine();
        string substr = Console.ReadLine();
        int count = 0;
        for (int i = 0; i <= s.Length - substr.Length; i++)
        {
            if (s.Substring(i, substr.Length) == substr)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}