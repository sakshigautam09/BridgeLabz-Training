using System;
class LongestWord
{
    static void Main()
    {
        string s = Console.ReadLine();
        string[] words = s.Split(' ');
        string ans = "";
        foreach (string word in words)
        {
            if (word.Length > ans.Length)
            {
                ans = word;
            }
        }
        Console.WriteLine(ans);
    }
}