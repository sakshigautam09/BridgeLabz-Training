using System;
class SumOfNaturalNumbers
{
    static int RecursiveSum(int n)
    {
        if (n == 0) return 0;
        return n + RecursiveSum(n - 1);
    }
    static int FormulaSum(int n) {
        return n * (n + 1) / 2;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }
        int sum1 = RecursiveSum(n);
        int sum2 = FormulaSum(n);

        Console.WriteLine("Recursive Sum: " + sum1);
        Console.WriteLine("Formula Sum: " + sum2);
        Console.WriteLine("Equal? : " + (sum1 == sum2));
    }
}
