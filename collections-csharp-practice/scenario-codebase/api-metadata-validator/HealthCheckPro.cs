using System;
using System.Reflection;

public class HealthCheckPro
{
    public static void Main()
    {
        Scan(typeof(LabController));
    }

    static void Scan(Type controller)
    {
        Console.WriteLine("API Documentation");

        MethodInfo[] methods = controller.GetMethods();

        foreach (MethodInfo method in methods)
        {
            bool isPublic = method.IsDefined(typeof(PublicAPI), false);
            bool isAuth = method.IsDefined(typeof(RequiresAuth), false);

            Console.WriteLine("Method: " + method.Name);

            if (!isPublic && !isAuth)
            {
                Console.WriteLine("Missing API annotations");
            }
            else
            {
                if (isPublic)
                    Console.WriteLine("Annotation: @PublicAPI");

                if (isAuth)
                    Console.WriteLine("Annotation: @RequiresAuth");
            }
        }
    }
}
