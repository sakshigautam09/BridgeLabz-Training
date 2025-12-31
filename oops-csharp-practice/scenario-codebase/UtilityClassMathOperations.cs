using System;
class Program
{
    // Factorial
    static long Factorial(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("Factorial not defined for negative numbers.");
            return -1;
        }
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
    // Prime check
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0)
                return false;
        return true;
    }
    // Greatest Common Divisor
    static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    // nth Fibonacci
    static long Fibonacci(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("Fibonacci not defined for negative numbers.");
            return -1;
        }
        if (n == 0) return 0;
        if (n == 1) return 1;
        long a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Math Utility Menu ---");
            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. Check Prime");
            Console.WriteLine("3. GCD");
            Console.WriteLine("4. Fibonacci");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string chooseOption = Console.ReadLine();
            switch (chooseOption)
            {
                case "1":
                    Console.Write("Enter a number: ");
                    int num = int.Parse(Console.ReadLine());
                    long fact = Factorial(num);
                    if (fact != -1) Console.WriteLine($"Factorial of {num} = {fact}");
                    break;
                case "2":
                    Console.Write("Enter a number: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{num} is prime? {IsPrime(num)}");
                    break;
                case "3":
                    Console.Write("Enter first number: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"GCD({a}, {b}) = {GCD(a, b)}");
                    break;
                case "4":
                    Console.Write("Enter n: ");
                    int num = int.Parse(Console.ReadLine());
                    long fib = Fibonacci(num);
                    if (fib != -1) Console.WriteLine($"Fibonacci({num}) = {fib}");
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }
}
    