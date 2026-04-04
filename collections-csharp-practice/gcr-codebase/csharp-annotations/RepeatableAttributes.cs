using System;
using System.Reflection;

// --------------------- Repeatable Custom Attribute ---------------------
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReportAttribute : Attribute
{
    public string Description { get; set; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

// --------------------- Sample Class with Methods ---------------------
public class SoftwareModule
{
    [BugReport("NullReferenceException occurs on empty input")]
    [BugReport("UI freezes when clicking submit too fast")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }

    [BugReport("Incorrect calculation for negative numbers")]
    public void Calculate()
    {
        Console.WriteLine("Calculating...");
    }
}

// --------------------- Example Usage with Reflection ---------------------
public class RepeatableAttributes
{
    public static void Main()
    {
        SoftwareModule module = new SoftwareModule();
        Type type = typeof(SoftwareModule);

        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            object[] attributes = method.GetCustomAttributes(typeof(BugReportAttribute), false);

            foreach (BugReportAttribute bug in attributes)
            {
                Console.WriteLine($"Method: {method.Name}, Bug: {bug.Description}");
            }
        }
    }
}
