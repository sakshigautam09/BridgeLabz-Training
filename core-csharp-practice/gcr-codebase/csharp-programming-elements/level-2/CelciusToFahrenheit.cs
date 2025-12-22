using System;
class CelciusToFahrenheit
{
    static void Main()
    {
        Console.Write("Enter temp in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"The {celsius} Celsius is {fahrenheit} Fahrenheit");
    }
}
