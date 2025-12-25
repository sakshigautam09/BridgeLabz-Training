using System;
class SumOfNaturalNumbers
{
    static int FindSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += i;
        return sum;
    }
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(FindSum(n));
    }
}
