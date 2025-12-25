using System;
class Palindrome
{
    static int[] StoreDigits(int num)
    {
        int temp = num;
        int count = 0;
        while (temp > 0) { 
            count++; 
            temp /= 10; 
        }
        int[] arr = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            arr[i] = num % 10;
            num /= 10;
        }
        return arr;
    }
    static int[] ReverseArray(int[] arr)
    {
        int[] rev = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            rev[i] = arr[arr.Length - 1 - i];
        return rev;
    }
    static bool Palin(int[] a, int[] b)
    {
        if (a.Length != b.Length) return false;
        for (int i = 0; i < a.Length; i++){
            if (a[i] != b[i]) {
                return false;
            }
        }
        return true;
    }
    static bool IsDuck(int[] digits)
    {
        foreach (int d in digits)
            if (d == 0) {
                return true;
            }
        return false;
    }
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());

        int[] digits = StoreDigits(num);
        int[] rev = ReverseArray(digits);

        Console.WriteLine("Palindrome: " + Palin(digits, rev));
        Console.WriteLine("Duck Number: " + IsDuck(digits));
    }
}
