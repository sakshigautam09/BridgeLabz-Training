using System;
using System.Reflection;

public class Person
{
    private int age = 25;
}

public class AccessPrivateFields
{
    public static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);

        FieldInfo field = type.GetField("age",
            BindingFlags.NonPublic | BindingFlags.Instance);

        field.SetValue(person, 30);

        int updatedAge = (int)field.GetValue(person);
        Console.WriteLine("Updated Age: " + updatedAge);
    }
}
