using System;
class NumberChecker
{
    static int CountDigits(int n)
    {
        int count = 0;
        while (n > 0) { 
            count++; 
            n /= 10; 
        }
        return count;
    }

    static int[] StoreDigits(int n)
    {
        int[] digits = new int[CountDigits(n)];
        int i = digits.Length - 1;
        while (n > 0)
        {
            digits[i--] = n % 10;
            n /= 10;
        }
        return digits;
    }

    static bool IsDuck(int[] digits)
    {
        for (int i = 0; i < digits.Length; i++)
            if (digits[i] != 0) {
                return true;
            }
        return false;
    }

    static bool IsArmstrong(int n, int[] digits)
    {
        int power = digits.Length;
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
            sum += (int)Math.Pow(digits[i], power);
        return sum == n;
    }

    static void Largest(int[] digits)
    {
        int max1 = Int32.MinValue;
        int max2 = Int32.MinValue;
        foreach (int d in digits)
        {
            if (d > max1) { 
                max2 = max1; 
                max1 = d; 
            }
            else if (d > max2 && d != max1) {
                max2 = d;
            }
        }
        Console.WriteLine("Largest: " + max1 + " Second Largest: " + max2);
    }

    static void Smallest(int[] digits)
    {
        int min1 = Int32.MaxValue;
        int min2 = Int32.MaxValue;
        foreach (int d in digits)
        {
            if (d < min1) { 
                min2 = min1; 
                min1 = d; 
                }
            else if (d < min2 && d != min1) {
                min2 = d;
            }
        }
        Console.WriteLine("Smallest: " + min1 + " Second Smallest: " + min2);
    }

    static void Main()
    {
        int n = 153;
        int[] digits = StoreDigits(n);

        Console.WriteLine("Duck: " + IsDuck(digits));
        Console.WriteLine("Armstrong: " + IsArmstrong(n, digits));
        Largest(digits);
        Smallest(digits);
    }
}
