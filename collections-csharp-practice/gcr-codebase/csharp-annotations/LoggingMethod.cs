using System;
using System.Diagnostics;
using System.Reflection;

// --------------------- Custom Attribute ---------------------
[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute
{
}

// --------------------- Class with Methods ---------------------
public class PerformanceTasks
{
    [LogExecutionTime]
    public void FastTask()
    {
        for (int i = 0; i < 1000000; i++)
        {
            // Simulating fast work
        }
    }

    [LogExecutionTime]
    public void SlowTask()
    {
        System.Threading.Thread.Sleep(2000); // Simulate slow work
    }

    public void NormalTask()
    {
        System.Threading.Thread.Sleep(500);
    }
}

// --------------------- Main Program ---------------------
public class LoggingMethod
{
    public static void Main()
    {
        PerformanceTasks tasks = new PerformanceTasks();
        Type type = typeof(PerformanceTasks);

        foreach (MethodInfo method in type.GetMethods(
                     BindingFlags.Public |
                     BindingFlags.Instance |
                     BindingFlags.DeclaredOnly))
        {
            object[] attributes =
                method.GetCustomAttributes(typeof(LogExecutionTimeAttribute), false);

            if (attributes.Length > 0)
            {
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                method.Invoke(tasks, null);
                stopwatch.Stop();

                Console.WriteLine(
                    "Method: " + method.Name +
                    " | Execution Time: " + stopwatch.ElapsedMilliseconds + " ms"
                );
            }
        }
    }
}
