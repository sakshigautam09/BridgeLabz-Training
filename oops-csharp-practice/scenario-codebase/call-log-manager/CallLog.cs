using System;
public class CallLog
{
    private string phoneNumber;
    private string message;
    private DateTime timestamp;

    public CallLog(string phoneNumber, string message, DateTime timestamp)
    {
        this.phoneNumber = phoneNumber;
        this.message = message;
        this.timestamp = timestamp;
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
    }

    public string Message
    {
        get { return message; }
    }

    public DateTime Timestamp
    {
        get { return timestamp; }
    }

    public void Display()
    {
        Console.WriteLine("Phone: " + phoneNumber);
        Console.WriteLine("Message: " + message);
        Console.WriteLine("Time: " + timestamp);
    }
}
