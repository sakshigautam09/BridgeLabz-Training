using System;
using System.Collections.Generic;
public class UnionIntersectionOfSets
{
    static void Main()
    {
        List<int> set1 = new List<int>();
        List<int> set2 = new List<int>();

        Console.Write("Enter number of elements in Set1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of Set1:");
        for (int i = 0; i < n1; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (!set1.Contains(num)) set1.Add(num);
        }

        Console.Write("Enter number of elements in Set2: ");
        int n2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter elements of Set2:");
        for (int i = 0; i < n2; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (!set2.Contains(num)) set2.Add(num);
        }

        // Union
        List<int> union = new List<int>(set1);
        foreach (int num in set2)
        {
            if (!union.Contains(num))
                union.Add(num);
        }

        // Intersection
        List<int> intersection = new List<int>();
        foreach (int num in set1)
        {
            if (set2.Contains(num))
                intersection.Add(num);
        }

        Console.Write("Union: ");
        foreach (int num in union)
            Console.Write(num + " ");
        Console.WriteLine();

        Console.Write("Intersection: ");
        foreach (int num in intersection)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
