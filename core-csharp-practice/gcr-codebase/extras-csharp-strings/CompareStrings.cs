using System;
class CompareStrings
{
     static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int ans = CompareStrings(s1, s2);

        if (ans < 0)
            Console.WriteLine($"{s1} comes before {s2} in lexicographical order");
        else if (ans > 0)
            Console.WriteLine($"{s1} comes after {s2} in lexicographical order");
        else
            Console.WriteLine("Both strings are equal");
    }
    static int CompareStrings(string s1, string s2)
    {
        int min = s1.Length < s2.Length ? s1.Length : s2.Length;

        for (int i = 0; i < min; i++)
        {
            if (s1[i] != s2[i])
                return s1[i] - s2[i];
        }
        return s1.Length - s2.Length;
    }
}