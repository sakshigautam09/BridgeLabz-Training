using System;
class PowerOfANumber
{
    static void Main()
    {
        int n, power;
        int ans = 1;

        Console.Write("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter power: ");
        power = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= power; i++)
        {
            ans *= n;
        }

        Console.WriteLine(ans);
    }
}
