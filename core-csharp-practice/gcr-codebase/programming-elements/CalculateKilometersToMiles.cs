using System;

public class CalculateKilometersToMiles
{
    public static void Main(string[] args)
    {
        // Read kilometers from user
        double kilometers = double.Parse(Console.ReadLine());

        // Convert to miles
        double miles = kilometers * 0.621371; // 1 km ≈ 0.621371 miles

        // Print result
        Console.WriteLine(miles);
    }
}