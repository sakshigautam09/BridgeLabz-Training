using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

// --------------------- PasswordValidator Class ---------------------
public class TestPasswordStrength
{
    // Validate password
    public bool IsValid(string password)
    {
        if (password == null)
        {
            return false;
        }

        if (password.Length < 8)
        {
            return false;
        }

        // At least one uppercase letter
        bool hasUppercase = false;
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUppercase = true;
                break;
            }
        }

        if (!hasUppercase)
        {
            return false;
        }

        // At least one digit
        bool hasDigit = false;
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                hasDigit = true;
                break;
            }
        }

        if (!hasDigit)
        {
            return false;
        }

        return true;
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

    [Test]
    public void ValidPasswords_ReturnsTrue()
    {
        Assert.IsTrue(validator.IsValid("Password1"));
        Assert.IsTrue(validator.IsValid("StrongPass123"));
        Assert.IsTrue(validator.IsValid("Abcdefg8H"));
    }

    [Test]
    public void InvalidPasswords_ReturnsFalse()
    {
        Assert.IsFalse(validator.IsValid("pass"));              // Too short
        Assert.IsFalse(validator.IsValid("password1"));         // No uppercase
        Assert.IsFalse(validator.IsValid("PASSWORD"));          // No digit
        Assert.IsFalse(validator.IsValid(null));                // Null input
        Assert.IsFalse(validator.IsValid("Short1"));            // Too short
    }
}
