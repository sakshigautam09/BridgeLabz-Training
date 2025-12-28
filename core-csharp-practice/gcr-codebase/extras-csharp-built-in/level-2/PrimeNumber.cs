using System;
class PrimeNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (IsPrime(num))
            Console.WriteLine(num + " is a Prime number");
        else
            Console.WriteLine(num + " is NOT a Prime number");
    }
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
