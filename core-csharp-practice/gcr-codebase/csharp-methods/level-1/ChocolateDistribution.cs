using System;
class ChocolateDistribution
{
    public static int[] FindRemainderAndQuotient(int chocolates, int children)
    {
        return new int[] { chocolates / children, chocolates % children };
    }
    static void Main()
    {
        int chocolates = int.Parse(Console.ReadLine());
        int children = int.Parse(Console.ReadLine());
        int[] ans = FindRemainderAndQuotient(chocolates, children);
        Console.WriteLine(ans[0]);
        Console.WriteLine(ans[1]);
    }
}
