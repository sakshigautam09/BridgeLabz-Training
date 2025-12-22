using System;
class CountNumberOfDigits
{
    static void Main()
    {
        int n, count = 0;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        while (n != 0)
        {
            n = n / 10;
            count++;
        }
        Console.WriteLine("Number of digits = " + count);
    }
}
