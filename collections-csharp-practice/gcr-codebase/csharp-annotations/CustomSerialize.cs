using System;
using System.Reflection;
using System.Text;

// --------------------- JsonField Attribute ---------------------
[AttributeUsage(AttributeTargets.Field)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

// --------------------- User Class ---------------------
public class User
{
    [JsonField("user_name")]
    private string Username;

    [JsonField("email_id")]
    private string Email;

    [JsonField("user_age")]
    private int Age;

    public User(string username, string email, int age)
    {
        Username = username;
        Email = email;
        Age = age;
    }
}

// --------------------- Custom JSON Serializer ---------------------
public class JsonSerializer
{
    public static string Serialize(object obj)
    {
        StringBuilder json = new StringBuilder();
        Type type = obj.GetType();

        json.Append("{");
        bool firstField = true;

        FieldInfo[] fields =
            type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (FieldInfo field in fields)
        {
            object[] attributes =
                field.GetCustomAttributes(typeof(JsonFieldAttribute), false);

            if (attributes.Length > 0)
            {
                JsonFieldAttribute jsonAttr =
                    (JsonFieldAttribute)attributes[0];

                object value = field.GetValue(obj);

                if (!firstField)
                {
                    json.Append(", ");
                }

                json.Append("\"" + jsonAttr.Name + "\": ");

                if (value is string)
                {
                    json.Append("\"" + value + "\"");
                }
                else
                {
                    json.Append(value);
                }

                firstField = false;
            }
        }

        json.Append("}");
        return json.ToString();
    }
}

// --------------------- Main Program ---------------------
public class CustomSerialize
{
    public static void Main()
    {
        User user = new User("Sakshi", "sakshi@gmail.com", 22);

        string json = JsonSerializer.Serialize(user);

        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);
    }
}
