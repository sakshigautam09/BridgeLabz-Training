using System;
using System.Reflection;

// --------------------- Custom Attribute ---------------------
[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; set; }

    // Optional parameter with default value
    public ImportantMethodAttribute()
    {
        Level = "HIGH";
    }

    public ImportantMethodAttribute(string level)
    {
        Level = level;
    }
}

// --------------------- Sample Class with Annotated Methods ---------------------
public class TaskProcessor
{
    [ImportantMethod] // Uses default Level "HIGH"
    public void CriticalTask()
    {
        Console.WriteLine("Executing critical task...");
    }

    [ImportantMethod("MEDIUM")] // Custom Level
    public void RoutineTask()
    {
        Console.WriteLine("Executing routine task...");
    }

    public void NormalTask()
    {
        Console.WriteLine("Executing normal task...");
    }
}

// --------------------- Example Usage with Reflection ---------------------
public class ImpMethods
{
    public static void Main()
    {
        Type type = typeof(TaskProcessor);

        Console.WriteLine("Annotated Methods:");

        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            object[] attributes = method.GetCustomAttributes(typeof(ImportantMethodAttribute), false);

            foreach (ImportantMethodAttribute attr in attributes)
            {
                Console.WriteLine($"Method: {method.Name}, Level: {attr.Level}");
            }
        }
    }
}
