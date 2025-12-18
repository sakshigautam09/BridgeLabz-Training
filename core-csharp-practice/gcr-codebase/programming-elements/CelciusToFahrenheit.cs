using System;

public class CelsiusToFahrenheit
{
    public static void Main(string[] args)
    {

        // Read Celsius value
        double celsius = double.Parse(Console.ReadLine());

        // Convert to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Print result
        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
    }
}
