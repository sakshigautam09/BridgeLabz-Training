using System;
class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2.Fahrenheit to Celsius");
        Console.Write("Choose option: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("Enter Celsius: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(c));
        }
        else if (choice == 2)
        {
            Console.Write("Enter Fahrenheit: ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius: " + FahrenheitToCelsius(f));
        }
    }
    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}
