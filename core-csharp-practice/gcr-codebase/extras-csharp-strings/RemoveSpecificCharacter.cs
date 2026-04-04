using System;
class RemoveSpecificCharacter
{
    static void Main()
    {
        string s = Console.ReadLine();
        char ch = (char)Console.ReadLine();
        string ans = "";
        foreach (char c in s)
        {
            if (c != ch)
            {
                ans += c;
            }
        }
        Console.WriteLine(ans);
    }
}