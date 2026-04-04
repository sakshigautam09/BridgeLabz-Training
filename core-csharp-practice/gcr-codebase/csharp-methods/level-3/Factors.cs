using System;
class Factors
{
    static int[] GetFactors(int num)
    {
        int count = 0;
        for (int i = 1; i <= num; i++)
            if (num % i == 0) count++;

        int[] factors = new int[count];
        int idx = 0;
        for (int i = 1; i <= num; i++)
            if (num % i == 0) {
                factors[idx++] = i;
            }
        return factors;
    }

    static int SumProperDivisors(int num)
    {
        int sum = 0;
        for (int i = 1; i < num; i++)
            if (num % i == 0) {
                sum += i;
            }
        return sum;
    }

    static int Factorial(int n)
    {
        int f = 1;
        for (int i = 1; i <= n; i++) f *= i;
        return f;
    }

    static bool IsStrong(int num)
    {
        int temp = num, sum = 0;
        while (temp > 0)
        {
            sum += Factorial(temp % 10);
            temp /= 10;
        }
        return sum == num;
    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sumDiv = SumProperDivisors(num);

        Console.WriteLine("Perfect: " + (sumDiv == num));
        Console.WriteLine("Abundant: " + (sumDiv > num));
        Console.WriteLine("Deficient: " + (sumDiv < num));
        Console.WriteLine("Strong: " + IsStrong(num));
    }
}
