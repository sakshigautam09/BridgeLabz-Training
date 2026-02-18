using System;

public class AddressBookException : Exception
{
    public AddressBookException() { }

    public AddressBookException(string message) : base(message) { }

    public AddressBookException(string message, Exception inner) : base(message, inner) { }
}
