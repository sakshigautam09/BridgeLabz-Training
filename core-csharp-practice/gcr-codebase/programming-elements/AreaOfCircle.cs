using System;

public class AreaOfACircle
{
    public static void Main(string[] args)
    {
        // Read radius from user
        double radius = double.Parse(Console.ReadLine());

        // Calculate area
        double area = Math.PI * radius * radius;

        // Print result
        Console.WriteLine("Area of Circle = " + area);
    }
}
