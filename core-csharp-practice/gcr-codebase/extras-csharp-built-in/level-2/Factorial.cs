using System;
class Factorial
{
    static void Main()
    {
        int n = ReadNumber();
        int ans = Factorial(n);
        DisplayResult(ans);
    }
    static int ReadNumber()
    {
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }
    static void DisplayResult(int ans)
    {
        Console.WriteLine("Factorial is: " + ans);
    }
}
