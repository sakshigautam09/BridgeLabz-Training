using System;
using System.Diagnostics;
using System.Reflection;

public class Worker
{
    public void DoWork()
    {
        for (int i = 0; i < 100000000; i++) { }
    }
}

public class MethodExecutionTiming
{
    public static void Main()
    {
        Worker worker = new Worker();
        Type type = typeof(Worker);

        MethodInfo method = type.GetMethod("DoWork");

        Stopwatch watch = new Stopwatch();
        watch.Start();

        method.Invoke(worker, null);

        watch.Stop();
        Console.WriteLine("Execution Time: " + watch.ElapsedMilliseconds + " ms");
    }
}
