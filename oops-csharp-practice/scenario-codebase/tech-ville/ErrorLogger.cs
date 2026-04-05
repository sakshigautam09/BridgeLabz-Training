using System;
using System.IO;

public class ErrorLogger
{
    public void LogError(string message)
    {
        try
        {
            File.AppendAllText("error_log.txt",
                DateTime.Now + " : " + message + "\n");
        }
        catch
        {
            Console.WriteLine("Logging failed.");
        }
    }
}
