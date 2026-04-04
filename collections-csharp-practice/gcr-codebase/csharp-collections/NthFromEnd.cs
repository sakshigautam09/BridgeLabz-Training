using System;
using System.Collections.Generic;

public class NthFromEnd
{
    static void Main()
    {
        List<string> list = new List<string>();

        Console.Write("Enter number of elements: ");
        int nElems = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < nElems; i++)
        {
            list.Add(Console.ReadLine());
        }

        Console.Write("Enter N (from end): ");
        int N = int.Parse(Console.ReadLine());

        if (N > list.Count || N <= 0)
        {
            Console.WriteLine("Invalid N");
            return;
        }

        int iIndex = N; // lead index
        int jIndex = 0; // trailing index

        while (iIndex < list.Count)
        {
            iIndex++;
            jIndex++;
        }

        Console.WriteLine("Nth element from end:");
        Console.WriteLine(list[jIndex]);
    }
}
