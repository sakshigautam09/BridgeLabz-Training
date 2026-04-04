using System;
class MaximumOfThree
{
    static void Main()
    {
        int a = ReadNum("Enter first number: ");
        int b = ReadNum("Enter second number: ");
        int c = ReadNum("Enter third number: ");

        int max = FindMaximum(a, b, c);
        Console.WriteLine("Maximum number is: " + max);
    }
    static int ReadNum()
    {
        return int.Parse(Console.ReadLine());
    }
    static int FindMaximum(int x, int y, int z)
    {
        int max = x;
        if (y > max)
            max = y;
        if (z > max)
            max = z;
        return max;
    }
}
