using System;
using System.Collections.Generic;
public class FindSubsets
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

        bool isSubset = true;
        foreach (int item in set1)
        {
            if (!set2.Contains(item))
            {
                isSubset = false;
                break;
            }
        }

        Console.WriteLine("Is Set1 a subset of Set2? " + isSubset);
    }
}
