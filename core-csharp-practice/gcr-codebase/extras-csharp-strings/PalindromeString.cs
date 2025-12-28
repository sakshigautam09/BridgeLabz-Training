using System;
class PalindromeString
{
    static void Main()
    {
        string s = Console.ReadLine();
        int l = 0;
        int r = s.Length - 1;
        bool isPalin = true;
        while (l < r)
        {
            if (s[l] != s[r])
            {
                isPalin = false;
                break;
            }
            l++;
            r--;
        }
        if (isPalin)
        {
            Console.WriteLine("string is palindrome.");
        }
        else
        {
            Console.WriteLine("string is not palindrome.");
        }
    }
}