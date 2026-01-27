using System;
using NUnit.Framework;

// --------------------- Calculator Class ---------------------
public class TestingCalculator
{
    // Addition
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Subtraction
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // Multiplication
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    // Division with exception handling
    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        // Create a new Calculator instance before each test
        calculator = new Calculator();
    }

    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        Assert.AreEqual(8, calculator.Add(5, 3));
        Assert.AreEqual(-2, calculator.Add(-1, -1));
    }

    [Test]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        Assert.AreEqual(6, calculator.Subtract(10, 4));
        Assert.AreEqual(0, calculator.Subtract(5, 5));
    }

    [Test]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        Assert.AreEqual(42, calculator.Multiply(6, 7));
        Assert.AreEqual(0, calculator.Multiply(0, 7));
    }

    [Test]
    public void Divide_TwoNumbers_ReturnsQuotient()
    {
        Assert.AreEqual(5, calculator.Divide(20, 4));
        Assert.AreEqual(-2, calculator.Divide(-8, 4));
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        // Check that dividing by zero throws DivideByZeroException
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
}
