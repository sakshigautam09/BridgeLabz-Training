using System;
class RemoveDuplicates
{
    static void Main()
    {
        string s = Console.ReadLine();
        string ans = "";
        foreach (char c in s)
        {
            if (!ans.Contains(c))
            {
                ans += c;
            }
        }
        Console.WriteLine(ans);
    }
}