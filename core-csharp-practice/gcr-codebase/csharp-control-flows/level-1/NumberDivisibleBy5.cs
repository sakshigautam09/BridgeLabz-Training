using System;
class NumberDivisibleBy5
{
    static void Main(String[] args)
    {
        int n;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n % 5 == 0)
        {
            Console.WriteLine($"Is the number {n} divisible by 5? Yes");
        }
        else
        {
            Console.WriteLine($"Is the number {n} divisible by 5? No");
        }
    }
}