using System;
using System.Reflection;

public class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class InvokePrivateMethod
{
    public static void Main()
    {
        Calculator calc = new Calculator();
        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod("Multiply",
            BindingFlags.NonPublic | BindingFlags.Instance);

        object result = method.Invoke(calc, new object[] { 5, 6 });

        Console.WriteLine("Result: " + result);
    }
}
