using System;
using System.Reflection;

// ---------- Custom Attribute ----------
[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name;

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// ---------- Apply Attribute ----------
[Author("Sakshi Gautam")]
public class Project
{
    public void Show()
    {
        Console.WriteLine("Project class executed");
    }
}

// ---------- Main ----------
public class RetrieveAttributes
{
    public static void Main()
    {
        Type type = typeof(Project);

        object[] attributes =
            type.GetCustomAttributes(typeof(AuthorAttribute), false);

        if (attributes.Length > 0)
        {
            AuthorAttribute author =
                (AuthorAttribute)attributes[0];

            Console.WriteLine("Author: " + author.Name);
        }
    }
}
