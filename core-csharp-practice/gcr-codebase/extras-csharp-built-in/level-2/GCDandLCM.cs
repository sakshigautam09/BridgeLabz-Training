using System;
class GCDandLCM
{
    static void Main()
    {
        int a = ReadNumber("Enter first number: ");
        int b = ReadNumber("Enter second number: ");
        int gcd = FindGCD(a, b);
        int lcm = FindLCM(a, b);
        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
    }
    static int ReadNumber(string msg)
    {
        Console.Write(msg);
        return int.Parse(Console.ReadLine());
    }
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }
}
