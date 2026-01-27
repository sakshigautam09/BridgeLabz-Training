using System;
using NUnit.Framework;

// --------------------- DateFormatter Class ---------------------
public class DateFormatter
{
    // Convert "yyyy-MM-dd" to "dd-MM-yyyy"
    public string FormatDate(string inputDate)
    {
        if (string.IsNullOrEmpty(inputDate))
        {
            throw new ArgumentException("Input date cannot be null or empty.");
        }

        DateTime date;
        bool success = DateTime.TryParseExact(
            inputDate,
            "yyyy-MM-dd",
            System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None,
            out date
        );

        if (!success)
        {
            throw new FormatException("Invalid date format. Expected yyyy-MM-dd.");
        }

        return date.ToString("dd-MM-yyyy");
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class DateFormatterTests
{
    private DateFormatter formatter;

    [SetUp]
    public void Setup()
    {
        formatter = new DateFormatter();
    }

    [Test]
    public void FormatDate_ValidDate_ReturnsFormattedDate()
    {
        Assert.AreEqual("25-01-2026", formatter.FormatDate("2026-01-25"));
        Assert.AreEqual("01-12-2025", formatter.FormatDate("2025-12-01"));
    }

    [Test]
    public void FormatDate_InvalidDate_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() => formatter.FormatDate("25/01/2026")); // wrong format
        Assert.Throws<FormatException>(() => formatter.FormatDate("2026-13-01")); // invalid month
        Assert.Throws<FormatException>(() => formatter.FormatDate("2026-00-10")); // invalid month
    }

    [Test]
    public void FormatDate_NullOrEmpty_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => formatter.FormatDate(null));
        Assert.Throws<ArgumentException>(() => formatter.FormatDate(""));
    }
}
