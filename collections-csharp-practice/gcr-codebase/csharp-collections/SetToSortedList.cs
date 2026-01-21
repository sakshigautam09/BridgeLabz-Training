using System;
using System.Collections.Generic;

public class SetToSortedList
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>();

        Console.Write("Enter number of elements in the set: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            set.Add(int.Parse(Console.ReadLine()));
        }

        // convert HashSet to List
        List<int> sortedList = new List<int>(set);

        // manual insertion sort
        for (int i = 1; i < sortedList.Count; i++)
        {
            int key = sortedList[i];
            int j = i - 1;

            // shift elements greater than key to right
            while (j >= 0 && sortedList[j] > key)
            {
                sortedList[j + 1] = sortedList[j];
                j--;
            }
            sortedList[j + 1] = key;
        }

        Console.WriteLine("Sorted List:");
        foreach (int num in sortedList)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
