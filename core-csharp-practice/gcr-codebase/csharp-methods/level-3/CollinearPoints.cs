using System;
class CollinearPoints
{
    static bool CollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        if (slopeAB == slopeBC && slopeBC == slopeAC)
            return true;
        else
            return false;
    }
    static bool CollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        if (area == 0)
            return true;
        else
            return false;
    }

    static void Main()
    {
        double x1, y1, x2, y2, x3, y3;
        x1 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());

        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());

        x3 = double.Parse(Console.ReadLine());
        y3 = double.Parse(Console.ReadLine());

        bool slope = CollinearBySlope(x1, y1, x2, y2, x3, y3);
        bool area = CollinearByArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine(slope ? "Collinear" : "not Collinear");
        Console.WriteLine(area ? "Collinear" : "not Collinear");
    }
}
