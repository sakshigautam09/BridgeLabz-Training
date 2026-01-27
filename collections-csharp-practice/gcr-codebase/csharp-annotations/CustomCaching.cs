using System;
using System.Collections.Generic;
using System.Reflection;

// --------------------- CacheResult Attribute ---------------------
[AttributeUsage(AttributeTargets.Method)]
public class CacheResultAttribute : Attribute
{
}

// --------------------- Cache Manager ---------------------
public class CacheManager
{
    private static Dictionary<string, object> cache =
        new Dictionary<string, object>();

    public static object Execute(object obj, string methodName, object[] parameters)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName);

        // Check if method has CacheResult attribute
        bool isCached =
            method.IsDefined(typeof(CacheResultAttribute), false);

        string cacheKey = GenerateKey(methodName, parameters);

        if (isCached && cache.ContainsKey(cacheKey))
        {
            Console.WriteLine("✔ Returning cached result");
            return cache[cacheKey];
        }

        Console.WriteLine("⏳ Executing method...");
        object result = method.Invoke(obj, parameters);

        if (isCached)
        {
            cache[cacheKey] = result;
        }

        return result;
    }

    private static string GenerateKey(string methodName, object[] parameters)
    {
        string key = methodName;
        foreach (object param in parameters)
        {
            key += "_" + param.ToString();
        }
        return key;
    }
}

// --------------------- Expensive Service ---------------------
public class MathService
{
    [CacheResult]
    public int CalculateSquare(int number)
    {
        // Simulating expensive computation
        for (int i = 0; i < 100000000; i++)
        {
        }

        return number * number;
    }
}

// --------------------- Main Program ---------------------
public class CustomCaching
{
    public static void Main()
    {
        MathService service = new MathService();

        Console.WriteLine(CacheManager.Execute(service, "CalculateSquare", new object[] { 5 }));
        Console.WriteLine(CacheManager.Execute(service, "CalculateSquare", new object[] { 5 }));
        Console.WriteLine(CacheManager.Execute(service, "CalculateSquare", new object[] { 10 }));
        Console.WriteLine(CacheManager.Execute(service, "CalculateSquare", new object[] { 10 }));
    }
}
