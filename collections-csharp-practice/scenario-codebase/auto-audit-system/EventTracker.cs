using System;
using System.Reflection;
using System.Text.Json;
using System.Collections.Generic;

public class EventTracker
{
    public static void Main()
    {
        ScanAuditedMethods(typeof(UserActions));
    }

    public static void ScanAuditedMethods(Type type)
    {
        MethodInfo[] methods = type.GetMethods();

        var logs = new List<Dictionary<string, string>>();

        foreach (MethodInfo method in methods)
        {
            var attr = method.GetCustomAttribute<AuditTrail>();

            if (attr != null)
            {
                var logEntry = new Dictionary<string, string>
                {
                    { "Method", method.Name },
                    { "Action", attr.Action != "" ? attr.Action : method.Name },
                    { "Timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
                };

                logs.Add(logEntry);
            }
        }

        // Convert to JSON
        string jsonOutput = JsonSerializer.Serialize(logs, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(jsonOutput);
    }
}