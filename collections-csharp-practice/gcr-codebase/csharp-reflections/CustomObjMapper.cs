using System;
using System.Collections.Generic;
using System.Reflection;

public class ObjectMapper
{
    public static T ToObject<T>(Dictionary<string, object> data)
        where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (KeyValuePair<string, object> item in data)
        {
            FieldInfo field =
                type.GetField(item.Key,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(obj, item.Value);
            }
        }

        return obj;
    }
}

public class Person
{
    public string Name;
    private int Age;

    public void Show()
    {
        Console.WriteLine("Name: " + Name + ", Age: " + Age);
    }
}

public class CustomObjMapper
{
    public static void Main()
    {
        Dictionary<string, object> values = new Dictionary<string, object>();
        values.Add("Name", "Sakshi");
        values.Add("Age", 22);

        Person p = ObjectMapper.ToObject<Person>(values);
        p.Show();
    }
}
