using System;
public class CallLogManager
{
    private CallLog[] logs;
    private int count;

    public CallLogManager(int capacity)
    {
        logs = new CallLog[capacity];
        count = 0;
    }

    public void AddCallLog(CallLog log)
    {
        if (count >= logs.Length)
        {
            Console.WriteLine("Log storage is full!");
            return;
        }

        logs[count++] = log;
        Console.WriteLine("Call log added successfully.");
    }

    public void SearchByKeyword(string keyword)
    {
        Console.WriteLine($"Searching logs with keyword: {keyword}");
        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                logs[i].Display();
            }
        }
    }

    public void FilterByTime(DateTime start, DateTime end)
    {
        Console.WriteLine($"Logs between {start} and {end}");

        for (int i = 0; i < count; i++)
        {
            if (logs[i].Timestamp >= start && logs[i].Timestamp <= end)
            {
                logs[i].Display();
            }
        }
    }
}
