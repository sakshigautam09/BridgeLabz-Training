using System;
using System.Text.RegularExpressions;

class ValidateIP
{
    static void Main()
    {
        string[] ips = { "192.168.1.1", "256.100.50.25", "10.0.0" };

        string pattern = @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

        foreach (string ip in ips)
        {
            Console.WriteLine($"{ip} → {(Regex.IsMatch(ip, pattern) ? "Valid" : "Invalid")}");
        }
    }
}
