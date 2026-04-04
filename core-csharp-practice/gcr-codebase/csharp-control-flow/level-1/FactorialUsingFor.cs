using System;
class FactorialUsingFor
{
    static void Main()
    {
        int n;
        long fact = 1;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial of " + n + " is " + fact);
        }
        else
        {
            Console.WriteLine("Please enter a natural number");
        }
    }
}
