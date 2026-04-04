using System;
using NUnit.Framework;

// --------------------- StringUtils Class ---------------------
public class TestingStrings
{
    // Reverse a string
    public string Reverse(string str)
    {
        if (str == null) return null;
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Check if a string is palindrome (case-insensitive)
    public bool IsPalindrome(string str)
    {
        if (str == null) return false;
        string reversed = Reverse(str);
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    // Convert string to uppercase
    public string ToUpperCase(string str)
    {
        if (str == null) return null;
        return str.ToUpper();
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class StringUtilsTests
{
    private StringUtils utils;

    [SetUp]
    public void Setup()
    {
        utils = new StringUtils();
    }

    [Test]
    public void Reverse_String_ReturnsReversed()
    {
        Assert.AreEqual("olleh", utils.Reverse("hello"));
        Assert.AreEqual("madam", utils.Reverse("madam"));  // palindrome
        Assert.IsNull(utils.Reverse(null));                // null input
    }

    [Test]
    public void IsPalindrome_String_ReturnsTrueOrFalse()
    {
        Assert.IsTrue(utils.IsPalindrome("madam"));
        Assert.IsTrue(utils.IsPalindrome("RaceCar"));     // case-insensitive
        Assert.IsFalse(utils.IsPalindrome("Hello"));
        Assert.IsFalse(utils.IsPalindrome(null));         // null input
    }

    [Test]
    public void ToUpperCase_String_ReturnsUpperCase()
    {
        Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
        Assert.AreEqual("TEST123", utils.ToUpperCase("Test123"));
        Assert.IsNull(utils.ToUpperCase(null));           // null input
    }
}
