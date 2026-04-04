using System;
using NUnit.Framework;

// --------------------- TemperatureConverter Class ---------------------
public class TestingTemperature
{
    // Convert Celsius to Fahrenheit
    public double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Convert Fahrenheit to Celsius
    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_ValidInput_ReturnsCorrectFahrenheit()
    {
        Assert.AreEqual(32, converter.CelsiusToFahrenheit(0));
        Assert.AreEqual(212, converter.CelsiusToFahrenheit(100));
        Assert.AreEqual(98.6, converter.CelsiusToFahrenheit(37), 0.01); // allow small delta
    }

    [Test]
    public void FahrenheitToCelsius_ValidInput_ReturnsCorrectCelsius()
    {
        Assert.AreEqual(0, converter.FahrenheitToCelsius(32));
        Assert.AreEqual(100, converter.FahrenheitToCelsius(212));
        Assert.AreEqual(37, converter.FahrenheitToCelsius(98.6), 0.01); // allow small delta
    }
}
