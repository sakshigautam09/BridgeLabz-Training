using System;
using System.Collections.Generic;
public class SymmetricDifference
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

        List<int> symDiff = new List<int>();
        
        // Add elements from set1 not in set2
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
                symDiff.Add(num);
        }

        // Add elements from set2 not in set1
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
                symDiff.Add(num);
        }

        Console.Write("Symmetric Difference: ");
        foreach (int num in symDiff)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
