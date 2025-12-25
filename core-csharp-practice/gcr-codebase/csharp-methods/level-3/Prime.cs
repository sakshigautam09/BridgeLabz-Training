using System;
class Prime
{
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0) {
                return false;
            }
        return true;
    }

    static bool IsNeon(int num)
    {
        int sq = num * num;
        int sum = 0;
        while (sq > 0) { 
            sum += sq % 10; 
            sq /= 10; 
        }
        return sum == num;
    }

    static bool IsSpy(int num)
    {
        int sum = 0, prod = 1;
        while (num > 0)
        {
            int d = num % 10;
            sum += d; 
            prod *= d;
            num /= 10;
        }
        return sum == prod;
    }

    static bool IsAutomorphic(int num)
    {
        int sq = num * num;
        return sq.ToString().EndsWith(num.ToString());
    }

    static bool IsBuzz(int num)
    {
        return num % 7 == 0 || num % 10 == 7;
    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime: " + IsPrime(num));
        Console.WriteLine("Neon: " + IsNeon(num));
        Console.WriteLine("Spy: " + IsSpy(num));
        Console.WriteLine("Automorphic: " + IsAutomorphic(num));
        Console.WriteLine("Buzz: " + IsBuzz(num));
    }
}
