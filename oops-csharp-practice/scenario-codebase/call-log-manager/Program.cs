using System;
class Program
{
    static void Main(string[] args)
    {
        CallLogManager manager = new CallLogManager(5);

        CallLog log1 = new CallLog(
            "9876543210",
            "Network issue in my area",
            DateTime.Now.AddHours(-3)
        );

        CallLog log2 = new CallLog(
            "9123456789",
            "Billing problem, charged extra amount",
            DateTime.Now.AddHours(-1)
        );

        CallLog log3 = new CallLog(
            "9988776655",
            "SIM not working properly",
            DateTime.Now
        );

        manager.AddCallLog(log1);
        manager.AddCallLog(log2);
        manager.AddCallLog(log3);

        manager.SearchByKeyword("problem");

        DateTime startTime = DateTime.Now.AddHours(-2);
        DateTime endTime = DateTime.Now;

        manager.FilterByTime(startTime, endTime);

        Console.WriteLine("Program execution completed.");
    }
}
