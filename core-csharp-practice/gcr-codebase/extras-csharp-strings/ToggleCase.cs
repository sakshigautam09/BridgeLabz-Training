using System;
class ToggleCase
{
    static void Main()
    {
        string s = Console.ReadLine();
        char[] arr = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (char.IsUpper(c))
            {
                arr[i] = char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                arr[i] = char.ToUpper(c);
            }
            else
            {
                arr[i] = c;
            }
        }
        string toggled = new string(arr);
        Console.WriteLine(toggled);
    }
}