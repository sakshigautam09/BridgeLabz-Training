using System;
class FahrenheitToCelcius
{
    static void Main()
    {
        Console.Write("Enter temp in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsius} Celsius");
    }
}
