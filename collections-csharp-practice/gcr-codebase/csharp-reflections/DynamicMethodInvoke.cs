using System;
using System.Reflection;

public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class DynamicMethodInvoke
{
    public static void Main()
    {
        MathOperations obj = new MathOperations();
        Type type = typeof(MathOperations);

        Console.WriteLine("Enter method name (Add / Subtract / Multiply):");
        string methodName = Console.ReadLine();

        MethodInfo method = type.GetMethod(methodName);

        if (method != null)
        {
            object result = method.Invoke(obj, new object[] { 10, 5 });
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Method not found!");
        }
    }
}
