// ======================================
// UC-4: String utility methods
// name formatting, email validation
// ======================================

using System;

public class StringUtilities
{
    // Name formatting
    public string FormatName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return "Invalid Name";

        return char.ToUpper(name[0]) + name.Substring(1).ToLower();
    }

    // Email validation
    public bool ValidateEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }

    // Address parsing
    public string ParseAddress(string address)
    {
        return address.Trim();
    }
}
