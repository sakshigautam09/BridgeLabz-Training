using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
public class InjectAttribute : Attribute { }

public class Service
{
    public void Serve()
    {
        Console.WriteLine("Service executed");
    }
}

public class Client
{
    [Inject]
    private Service service;

    public void Run()
    {
        service.Serve();
    }
}

public class DIContainer
{
    public static void InjectDependencies(object obj)
    {
        FieldInfo[] fields =
            obj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (FieldInfo field in fields)
        {
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                object dependency = Activator.CreateInstance(field.FieldType);
                field.SetValue(obj, dependency);
            }
        }
    }
}

public class DependencyInjection
{
    public static void Main()
    {
        Client client = new Client();
        DIContainer.InjectDependencies(client);
        client.Run();
    }
}
