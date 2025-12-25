using System;
class WindChill
{
    public static double CalculateWindChill(double temp, double windSpeed)
    {
        return 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);
    }
    static void Main()
    {
        double temp = double.Parse(Console.ReadLine());
        double speed = double.Parse(Console.ReadLine());
        Console.WriteLine(CalculateWindChill(temp, speed));
    }
}
