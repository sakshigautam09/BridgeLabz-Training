using System;
using System.Reflection;

// --------------------- Custom Attribute ---------------------
[AttributeUsage(AttributeTargets.Method)] // Can only be applied to methods
public class TaskInfoAttribute : Attribute
{
    public string Priority { get; set; }
    public string AssignedTo { get; set; }

    // Constructor to initialize properties
    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

// --------------------- TaskManager Class ---------------------
public class TaskManager
{
    // Apply custom attribute to this method
    [TaskInfo("High", "Alice")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }

    [TaskInfo("Medium", "Bob")]
    public void ReviewTask()
    {
        Console.WriteLine("Task reviewed.");
    }
}

// --------------------- Example Usage with Reflection ---------------------
public class CustomAttributes
{
    public static void Main()
    {
        TaskManager manager = new TaskManager();

        // Get type information
        Type type = typeof(TaskManager);

        // Iterate through methods
        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            // Get custom attributes of type TaskInfoAttribute
            object[] attributes = method.GetCustomAttributes(typeof(TaskInfoAttribute), false);

            foreach (TaskInfoAttribute attr in attributes)
            {
                Console.WriteLine($"Method: {method.Name}, Priority: {attr.Priority}, AssignedTo: {attr.AssignedTo}");
            }
        }
    }
}
