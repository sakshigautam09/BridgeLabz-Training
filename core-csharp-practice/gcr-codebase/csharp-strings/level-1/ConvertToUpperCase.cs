using System;
class ConvertToUpperCase
{
    static void Main()
    {
        ConvertTextToUppercase();
    }
static void ConvertTextToUppercase()
    {
        string s = "Sakshi123";
        char[] arr = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (ch >= 'a' && ch <= 'z')
                arr[i] = (char)(ch - 32);
            else
                arr[i] = ch;
        }
        string manualUpper = new string(arr);
        string builtInUpper = s.ToUpper();

        Console.WriteLine(manualUpper);
        Console.WriteLine(builtInUpper);
    }
}