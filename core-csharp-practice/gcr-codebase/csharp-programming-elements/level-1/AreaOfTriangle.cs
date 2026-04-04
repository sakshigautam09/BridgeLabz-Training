using System;

class AreaOfTriangle
{
    static void Main()
    {
        double baseVal, height;

        Console.Write("Enter base in inches: ");
        baseVal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in inches: ");
        height = Convert.ToDouble(Console.ReadLine());

// 1 inch = 2.54 cm → 1 sq inch = 6.4516 sq cm
        double areaInches = 0.5 * baseVal * height;
        double areaCm = areaInches * 6.4516;

        Console.WriteLine("The area of triangle in square inches is " + areaInches + " and in square centimeters is " + areaCm);
    }
}
