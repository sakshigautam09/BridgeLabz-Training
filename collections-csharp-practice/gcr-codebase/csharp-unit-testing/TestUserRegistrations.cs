using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

// --------------------- UserRegistration Class ---------------------
public class TestUserRegistration
{
    // Register a new user
    public void RegisterUser(string username, string email, string password)
    {
        // Validate username
        if (string.IsNullOrEmpty(username))
        {
            throw new ArgumentException("Username cannot be null or empty.");
        }

        // Validate email (basic regex)
        if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            throw new ArgumentException("Invalid email address.");
        }

        // Validate password (minimum 8 chars, one uppercase, one digit)
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            throw new ArgumentException("Password must be at least 8 characters long.");
        }

        bool hasUppercase = false;
        bool hasDigit = false;
        foreach (char c in password)
        {
            if (char.IsUpper(c)) hasUppercase = true;
            if (char.IsDigit(c)) hasDigit = true;
        }

        if (!hasUppercase || !hasDigit)
        {
            throw new ArgumentException("Password must contain at least one uppercase letter and one digit.");
        }

        // If all validations pass, registration is considered successful
        // (No actual storage implemented for simplicity)
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration registration;

    [SetUp]
    public void Setup()
    {
        registration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ValidInput_DoesNotThrow()
    {
        Assert.DoesNotThrow(() => registration.RegisterUser("JohnDoe", "john@example.com", "Password1"));
        Assert.DoesNotThrow(() => registration.RegisterUser("Alice123", "alice@domain.com", "SecurePass9"));
    }

    [Test]
    public void RegisterUser_InvalidUsername_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("", "test@example.com", "Password1"));
        Assert.Throws<ArgumentException>(() => registration.RegisterUser(null, "test@example.com", "Password1"));
    }

    [Test]
    public void RegisterUser_InvalidEmail_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("JohnDoe", "invalidemail", "Password1"));
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("JohnDoe", "", "Password1"));
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("JohnDoe", null, "Password1"));
    }

    [Test]
    public void RegisterUser_InvalidPassword_ThrowsException()
    {
        // Too short
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("JohnDoe", "john@example.com", "Pass1"));

        // No uppercase
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("JohnDoe", "john@example.com", "password1"));

        // No digit
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("JohnDoe", "john@example.com", "Password"));
    }
}
