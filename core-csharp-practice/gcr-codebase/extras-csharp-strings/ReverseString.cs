using System;
class ReverseString
{
    static void Main()
    {
        string s = Console.ReadLine();
        char[] arr = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            arr[s.Length - 1 - i] = s[i];
        }
        string reversed = new string(arr);
        Console.WriteLine(reversed);
    }
}