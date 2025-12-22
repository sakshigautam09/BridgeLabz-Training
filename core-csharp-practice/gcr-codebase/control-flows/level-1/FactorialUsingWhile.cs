using System;
class FactorialUsingWhile
{
    static void Main()
    {
        int n;
        long fact = 1;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int i = 1;

            while (i <= n)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine("Factorial of " + n + " is " + fact);
        }
        else
        {
            Console.WriteLine("Please enter a positive integer");
        }
    }
}
