using System;
class MultiplesBelowHundred
{
    static void Main()
    {
        int n;
        Console.Write("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 100; i >= 1; i--)
        {
            if (i % n == 0)
                Console.WriteLine(i);
        }
    }
}
