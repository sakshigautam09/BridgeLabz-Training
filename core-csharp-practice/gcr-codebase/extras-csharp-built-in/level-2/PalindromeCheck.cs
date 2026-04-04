using System;
class PalindromeCheck
{
    static void Main()
    {
        string s = ReadString();
        if (IsPalindrome(s))
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a Palindrome");
    }
    static string ReadString()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }
    static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
