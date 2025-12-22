using System;
class AbundantNumber
{
    static void Main()
    {
        int n, sum = 0;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
                sum += i;
        }
        if (sum > n)
            Console.WriteLine("Abundant Number");
        else
            Console.WriteLine("Not an Abundant Number");
    }
}
