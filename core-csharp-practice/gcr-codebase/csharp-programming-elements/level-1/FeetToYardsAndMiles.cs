using System;
class FeetToYardsAndMiles
{
    static void Main()
    {
        double feet;
        Console.Write("Enter distance in feet: ");
        feet = Convert.ToDouble(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards / 1760;

        Console.WriteLine("The distance in yards is " + yards + " and in miles is " + miles);
    }
}