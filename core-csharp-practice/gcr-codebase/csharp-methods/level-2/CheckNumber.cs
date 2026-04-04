using System;
class CheckNumber
{
    static bool IsPositive(int n) {
        return n >= 0;
    }
    static bool IsEven(int n) {
        return n % 2 == 0;
    }
    static int Compare(int a, int b)
    {
        if (a > b) return 1;
        if (a == b) return 0;
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[5];
        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (IsPositive(arr[i]))
                Console.WriteLine(IsEven(arr[i]) ? "Positive Even" : "Positive Odd");
            else
                Console.WriteLine("Negative");
        }
        int ans = Compare(arr[0], arr[4]);
        Console.WriteLine(ans == 0 ? "Equal" : ans > 0 ? "First Greater" : "First Less");
    }
}
