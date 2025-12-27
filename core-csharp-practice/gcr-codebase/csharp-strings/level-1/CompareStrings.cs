using System;
class CompareStrings
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        bool methodCheck = AreEqual(s1, s2);
        bool builtInCheck = s1.Equals(s2);

        Console.WriteLine(methodCheck);
        Console.WriteLine(builtInCheck);
    }
    static bool AreEqual(string s1, string s2)
    {
        if(s1.Length!=s2.Length)
        {
            return false;
        }
        for(int i=0;i<s1.Length;i++)
        {
            if(s1[i]!=s2[i])
            {
                return false;
            }
        }
        return true;
    }
}