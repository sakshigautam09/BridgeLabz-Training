using System;

public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        int temp = x;
        int rev = 0;

        while (temp > 0)
        {
            int r = temp % 10;
            rev = rev * 10 + r;
            temp /= 10;
        }

        return rev == x;
    }
}