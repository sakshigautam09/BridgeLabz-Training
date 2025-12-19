using System;

public class CalculateAvgThreeNumbers{
    public static void Main(string[] args)
    {
        // Read three numbers from user
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        // Calculate average
        double average = (num1 + num2 + num3) / 3;

        // Print result
        Console.WriteLine(average);
    }
}
