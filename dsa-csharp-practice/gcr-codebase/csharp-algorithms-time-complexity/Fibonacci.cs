using System;
using System.Diagnostics;
class Fibonacci
{
    static void Main()
    {
        int n = 30;

        Stopwatch sw = new Stopwatch();

        // Recursive Fibonacci
        sw.Start();
        int recursiveResult = FibonacciRecursive(n);
        sw.Stop();

        Console.WriteLine("Recursive Fibonacci:");
        Console.WriteLine("Result: " + recursiveResult);
        Console.WriteLine("Time Taken: " + sw.Elapsed.TotalMilliseconds + " ms");

        // Iterative Fibonacci --------
        sw.Restart();
        int iterativeResult = FibonacciIterative(n);
        sw.Stop();

        Console.WriteLine("Iterative Fibonacci:");
        Console.WriteLine("Result: " + iterativeResult);
        Console.WriteLine("Time Taken: " + sw.Elapsed.TotalMilliseconds + " ms");
    }

    // Recursive Method
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Iterative Method
    static int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
