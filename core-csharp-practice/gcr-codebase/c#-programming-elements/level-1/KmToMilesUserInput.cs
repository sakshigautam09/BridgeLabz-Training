using System;
class KmToMilesUserInput
{
    static void Main()
    {
        double km;
        km = Convert.ToDouble(Console.ReadLine());
        double miles = km / 1.6;
        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}