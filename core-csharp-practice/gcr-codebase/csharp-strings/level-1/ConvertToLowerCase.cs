using System;
class ConvertToLowerCase
{
    static void Main()
    {
        ConvertTextToLowercase();
    }
static void ConvertTextToLowercase()
    {
        string s = "SAKSHI123";
        char[] arr = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (ch >= 'A' && ch <= 'Z')
                arr[i] = (char)(ch + 32);
            else
                arr[i] = ch;
        }
        string manualLower = new string(arr);
        string builtInLower = s.ToLower();
        Console.WriteLine(manualLower);
        Console.WriteLine(builtInLower);
    }
}