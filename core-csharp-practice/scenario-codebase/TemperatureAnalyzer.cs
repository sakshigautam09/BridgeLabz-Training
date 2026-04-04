using System;
class TemperatureAnalyzer
{
    static void Main()
    {
        float[,] temperatures = new float[7, 24];
        Random randomTemp = new Random();

        // Generate random temperatures between -10°C and 40°C
        for (int day = 0; day < 7; day++)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                temperatures[day, hour] = (float)(randomTemp.NextDouble() * 50 - 10); // -10 to 40
            }
        }

        FindHottestAndColdestDay(temperatures);
        PrintAverageTemperaturePerDay(temperatures);
    }

    static void FindHottestAndColdestDay(float[,] temps)
    {
        float maxTemp = float.MinValue;
        float minTemp = float.MaxValue;
        int hottestDay = -1;
        int coldestDay = -1;

        for (int day = 0; day < 7; day++)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                if (temps[day, hour] > maxTemp)
                {
                    maxTemp = temps[day, hour];
                    hottestDay = day;
                }
                if (temps[day, hour] < minTemp)
                {
                    minTemp = temps[day, hour];
                    coldestDay = day;
                }
            }
        }
        Console.WriteLine($"Hottest day: Day {hottestDay + 1} with {maxTemp:F2}°C");
        Console.WriteLine($"Coldest day: Day {coldestDay + 1} with {minTemp:F2}°C");
    }

    static void PrintAverageTemperaturePerDay(float[,] temps)
    {
        for (int day = 0; day < 7; day++)
        {
            float sum = 0;
            for (int hour = 0; hour < 24; hour++)
            {
                sum += temps[day, hour];
            }
            float avg = sum / 24;
            Console.WriteLine($"Average temperature for Day: {avg:F2}°C");
        }
    }
}
