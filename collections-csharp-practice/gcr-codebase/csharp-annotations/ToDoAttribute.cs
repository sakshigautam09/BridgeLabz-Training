using System;
using System.Reflection;

// --------------------- Custom Todo Attribute ---------------------
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; set; }
    public string AssignedTo { get; set; }
    public string Priority { get; set; }

    // Constructor with default priority
    public TodoAttribute(string task, string assignedTo)
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = "MEDIUM";
    }

    // Constructor with custom priority
    public TodoAttribute(string task, string assignedTo, string priority)
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

// --------------------- Class with Pending Tasks ---------------------
public class ProjectFeatures
{
    [Todo("Implement login validation", "Sakshi", "HIGH")]
    [Todo("Add unit tests for login", "Rahul")]
    public void LoginFeature()
    {
        Console.WriteLine("Login feature");
    }

    [Todo("Optimize search algorithm", "Aman", "LOW")]
    public void SearchFeature()
    {
        Console.WriteLine("Search feature");
    }

    [Todo("Add payment gateway integration", "Neha")]
    public void PaymentFeature()
    {
        Console.WriteLine("Payment feature");
    }
}

// --------------------- Retrieve Todo Attributes Using Reflection ---------------------
public class ToDoAttribute
{
    public static void Main()
    {
        Type type = typeof(ProjectFeatures);

        Console.WriteLine("Pending Tasks:\n");

        foreach (MethodInfo method in type.GetMethods(
                     BindingFlags.Public |
                     BindingFlags.Instance |
                     BindingFlags.DeclaredOnly))
        {
            object[] attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);

            foreach (TodoAttribute todo in attributes)
            {
                Console.WriteLine("Method: " + method.Name);
                Console.WriteLine("Task: " + todo.Task);
                Console.WriteLine("Assigned To: " + todo.AssignedTo);
                Console.WriteLine("Priority: " + todo.Priority);
                Console.WriteLine();
            }
        }
    }
}
