using System;
class SumOfNaturalNumbersUsingWhile
{
    static void Main()
    {
        int n;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                sum += i;
                i++;
            }

            int sumOfN = n * (n + 1) / 2;

            if (sum == sumOfN)
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
