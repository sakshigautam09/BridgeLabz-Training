using System;
class SumOfNaturalNumberUsingFor
{
    static void Main()
    {
        int n;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            int sumN = n * (n + 1) / 2;

            if (sum == sumN)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Results do not match.");
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }
}
