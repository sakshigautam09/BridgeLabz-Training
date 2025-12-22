using System;
class GreatestFactor
{
    static void Main()
    {
        int n, gf = 1;

        Console.Write("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = n - 1; i >= 1; i--)
        {
            if (n % i == 0)
            {
                gf = i;
                break;
            }
        }

        Console.WriteLine("Greatest Factor = " + gf);
    }
}
