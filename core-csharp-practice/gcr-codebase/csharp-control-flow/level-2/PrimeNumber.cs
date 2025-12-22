using System;
class PrimeNumber
{
    static void Main()
    {
        int n;
        bool isPrime = true;

        Console.Write("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not a Prime Number");
    }
}
