using System;
using NUnit.Framework;

// --------------------- EvenChecker Class ---------------------
public class TestingParameterizedTests
{
    // Returns true if number is even
    public bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class EvenCheckerTests
{
    private EvenChecker checker;

    [SetUp]
    public void Setup()
    {
        checker = new EvenChecker();
    }

    // Parameterized test for multiple values
    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_TestMultipleNumbers(int input, bool expected)
    {
        bool result = checker.IsEven(input);
        Assert.AreEqual(expected, result);
    }
}
