using System;

public class PowerCalculation
{
    public static void Main(string[] args)
    {
        // Read base and exponent from user
        int baseNum = int.Parse(Console.ReadLine());
        int exponent = int.Parse(Console.ReadLine());

        // Calculate power
        double result = Math.Pow(baseNum, exponent);

        // Print result
        Console.WriteLine(result);
    }
}
