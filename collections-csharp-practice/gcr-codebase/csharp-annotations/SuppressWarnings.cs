using System;
using System.Collections;

public class SuppressWarnings
{
    public static void Main()
    {
        // Disable warning CS0618 (if needed) or unchecked conversion warnings
        #pragma warning disable 618 // Example: suppress obsolete warnings
        #pragma warning disable 649 // Example: suppress uninitialized field warnings

        // Create non-generic ArrayList
        ArrayList list = new ArrayList();

        // Add elements (mixed types)
        list.Add(10);       // int
        list.Add("Hello");  // string
        list.Add(3.14);     // double

        // Iterate and display elements
        foreach (object item in list)
        {
            Console.WriteLine(item);
        }

        // Re-enable warnings after this block
        #pragma warning restore 618
        #pragma warning restore 649
    }
}
