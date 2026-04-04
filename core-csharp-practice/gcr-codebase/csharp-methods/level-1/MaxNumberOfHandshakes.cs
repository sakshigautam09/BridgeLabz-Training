using System;
class MaxNumberOfHandshakes
{
    static int CalcHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CalcHandshakes(n));
    }
}
