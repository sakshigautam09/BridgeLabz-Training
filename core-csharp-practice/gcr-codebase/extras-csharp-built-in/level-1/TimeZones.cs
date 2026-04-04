using System;
class TimeZones
{
    static void Main()
    {
        DateTimeOffset utc = DateTimeOffset.UtcNow;

        TimeZoneInfo gmt = TimeZoneInfo.Utc;
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        
        Console.WriteLine("GMT: " + TimeZoneInfo.ConvertTime(utc, gmt));
        Console.WriteLine("IST: " + TimeZoneInfo.ConvertTime(utc, ist));
        Console.WriteLine("PST: " + TimeZoneInfo.ConvertTime(utc, pst));
    }
}
