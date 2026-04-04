using System;
using System.Reflection;

public class Student
{
    public Student()
    {
        Console.WriteLine("Student object created");
    }

    public void Show()
    {
        Console.WriteLine("Hello from Student class");
    }
}

public class DynamicObject{
    public static void Main()
    {
        Type type = typeof(Student);

        object obj = Activator.CreateInstance(type);

        MethodInfo method = type.GetMethod("Show");
        method.Invoke(obj, null);
    }
}
