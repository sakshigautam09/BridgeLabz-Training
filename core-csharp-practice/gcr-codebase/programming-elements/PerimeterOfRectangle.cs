using System;

public class PerimeterOfRectangle
{
    public static void Main(string[] args)
    {
        // Read length and width from user
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        // Calculate perimeter
        double perimeter = 2 * (length + width);

        // Print result
        Console.WriteLine("Perimeter of Rectangle = " + perimeter);
    }
}
