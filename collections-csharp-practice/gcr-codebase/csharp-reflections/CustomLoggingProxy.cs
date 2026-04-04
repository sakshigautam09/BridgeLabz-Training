using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello(string name);
}

public class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine("Hello " + name);
    }
}

public class LoggingProxy
{
    public static void Invoke(object target, string methodName, object[] parameters)
    {
        Type type = target.GetType();
        MethodInfo method = type.GetMethod(methodName);

        Console.WriteLine("Logging: Calling method -> " + methodName);
        method.Invoke(target, parameters);
    }
}

public class CustomLoggingProxy
{
    public static void Main()
    {
        IGreeting greeting = new Greeting();
        LoggingProxy.Invoke(greeting, "SayHello", new object[] { "Sakshi" });
    }
}
