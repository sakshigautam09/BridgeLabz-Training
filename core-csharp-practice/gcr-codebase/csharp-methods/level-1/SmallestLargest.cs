using System;
class SmallestLargest
{
    public static int[] FindSmallestAndLargest(int a, int b, int c)
    {
        int smallest = Math.Min(a, Math.Min(b, c));
        int largest = Math.Max(a, Math.Max(b, c));
        return new int[] { smallest, largest };
    }
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int[] ans = FindSmallestAndLargest(a, b, c);
        Console.WriteLine(ans[0]);
        Console.WriteLine(ans[1]);
    }
}
