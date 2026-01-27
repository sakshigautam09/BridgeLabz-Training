using System;
using System.Reflection;
using System.Text;

public class JsonConverter
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields =
            type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        StringBuilder json = new StringBuilder();
        json.Append("{ ");

        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];
            object value = field.GetValue(obj);

            json.Append("\"" + field.Name + "\": ");

            if (value is string)
            {
                json.Append("\"" + value + "\"");
            }
            else
            {
                json.Append(value);
            }

            if (i < fields.Length - 1)
            {
                json.Append(", ");
            }
        }

        json.Append(" }");
        return json.ToString();
    }
}

public class User
{
    public string Username;
    private int Age;

    public User(string u, int a)
    {
        Username = u;
        Age = a;
    }
}

public class GenerateJSON
{
    public static void Main()
    {
        User user = new User("Sakshi", 22);
        string json = JsonConverter.ToJson(user);

        Console.WriteLine(json);
    }
}
