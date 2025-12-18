using System;

public class VolumeOfCylinder
{
    public static void Main(string[] args)
    {
        // Read radius and height from user
        double r = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        // Calculate volume
        double volume = Math.PI * r * r * h; // π * r^2 * h

        // Print result
        Console.WriteLine("Volume of Cylinder = " + volume);
    }
}
