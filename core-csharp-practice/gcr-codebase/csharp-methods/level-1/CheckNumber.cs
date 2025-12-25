using System;
class CheckNumber
{
    static int CheckNumber(int num)
    {
        if (num > 0) return 1;
        if (num < 0) return -1;
        return 0;
    }
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CheckNumber(num));
    }
}
