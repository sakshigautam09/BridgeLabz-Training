using System;
using System.Collections.Generic;
public class CheckSetsEqual
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();

        Console.Write("Enter number of elements in Set1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of Set1:");
        for (int i = 0; i < n1; i++)
        {
            set1.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Enter number of elements in Set2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of Set2:");
        for (int i = 0; i < n2; i++)
        {
            set2.Add(int.Parse(Console.ReadLine()));
        }

        bool areEqual = AreSetsEqual(set1, set2);

        Console.WriteLine("Are the sets equal? " + areEqual);
    }

    static bool AreSetsEqual(HashSet<int> s1, HashSet<int> s2)
    {
        if (s1.Count != s2.Count)
            return false;

        foreach (int item in s1)
        {
            if (!s2.Contains(item))
                return false;
        }
        return true;
    }
}
