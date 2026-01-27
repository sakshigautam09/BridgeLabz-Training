using System;
using NUnit.Framework;

// --------------------- Divider Class ---------------------
public class TestingException
{
    // Divide method
    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new ArithmeticException("Division by zero is not allowed.");
        }
        return a / b;
    }
}

// --------------------- NUnit Test ---------------------
[TestFixture]
public class DividerTests
{
    private Divider divider;

    [SetUp]
    public void Setup()
    {
        divider = new Divider();
    }

    [Test]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        int result = divider.Divide(10, 2);
        Assert.AreEqual(5, result);

        result = divider.Divide(20, 5);
        Assert.AreEqual(4, result);
    }

    [Test]
    public void Divide_ByZero_ThrowsArithmeticException()
    {
        Assert.Throws<ArithmeticException>(() => divider.Divide(10, 0));
    }
}
