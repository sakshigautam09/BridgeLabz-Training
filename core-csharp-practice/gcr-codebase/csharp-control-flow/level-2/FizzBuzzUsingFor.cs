using System;
class FizzBuzzUsingFor
{
    static void Main()
    {
        int n;
        Console.Write("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
