using System;
class FibonacciSequence
{
    static void Main()
    {
        int n = ReadNum();
        PrintFibonacci(n);
    }
    static int ReadNum()
    {
        return int.Parse(Console.ReadLine());
    }
    static void PrintFibonacci(int n)
    {
        int a = 0, b = 1;
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }
}
