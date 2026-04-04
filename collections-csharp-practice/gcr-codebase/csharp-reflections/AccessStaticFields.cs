using System;
using System.Reflection;

public class Configuration
{
    private static string API_KEY = "OLD_KEY";

    public static void ShowKey()
    {
        Console.WriteLine("API KEY: " + API_KEY);
    }
}

public class AccessStaticFields
{
    public static void Main()
    {
        Type type = typeof(Configuration);

        FieldInfo field =
            type.GetField("API_KEY",
            BindingFlags.Static | BindingFlags.NonPublic);

        field.SetValue(null, "NEW_SECURE_KEY");

        Configuration.ShowKey();
    }
}
