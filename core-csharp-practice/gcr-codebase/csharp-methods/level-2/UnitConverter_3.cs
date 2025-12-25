using System;

public static class UnitConvertor_3
{
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheitToCelsius = (fahrenheit - 32) * 5 / 9;
        return fahrenheitToCelsius;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsiusToFahrenheit = (celsius * 9 / 5) + 32;
        return celsiusToFahrenheit;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        double poundsToKg = 0.453592;
        return pounds * poundsToKg;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kgToPounds = 2.20462;
        return kilograms * kgToPounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallonsToLiters = 3.78541;
        return gallons * gallonsToLiters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double litersToGallons = 0.264172;
        return liters * litersToGallons;
    }
}
