using System;
class FactorsOfANumber
{
    static void Main()
    {
        int n;
        Console.Write("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }
    }
}
