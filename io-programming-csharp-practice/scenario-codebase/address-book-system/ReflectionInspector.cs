using System;
using System.Reflection;

public class ReflectionInspector
{
    public static void InspectType(Type type)
    {
        Console.WriteLine("\n--- REFLECTION OUTPUT ---");
        Console.WriteLine("Class Name: " + type.Name);

        // 🔹 Read Annotations
        object[] attributes = type.GetCustomAttributes(false);
        foreach (object attr in attributes)
        {
            if (attr is AddressBookMetadataAttribute meta)
            {
                Console.WriteLine("Module: " + meta.Module);
                Console.WriteLine("Author: " + meta.Author);
                Console.WriteLine("Version: " + meta.Version);
            }
        }

        // 🔹 Constructors
        Console.WriteLine("\nConstructors:");
        foreach (ConstructorInfo ctor in type.GetConstructors())
        {
            Console.WriteLine(ctor);
        }

        // 🔹 Fields
        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(field.FieldType.Name + " " + field.Name);
        }

        // 🔹 Methods
        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in type.GetMethods(
                     BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            Console.WriteLine(method.ReturnType.Name + " " + method.Name);
        }
    }
}
