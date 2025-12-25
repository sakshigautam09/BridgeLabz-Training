using System;
class QuotientRemainder
{
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number / divisor, number % divisor };
    }
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int divisor = Convert.ToInt32(Console.ReadLine());
        int[] ans = FindRemainderAndQuotient(number, divisor);
        Console.WriteLine(ans[0]);
        Console.WriteLine(ans[1]);
    }
}
