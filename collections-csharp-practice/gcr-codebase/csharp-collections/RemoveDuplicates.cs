using System;
using System.Collections.Generic;

public class RemoveDuplicates
{
    static void Main()
    {
        List<int> list = new List<int>();
        List<int> result = new List<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        // remove duplicates while preserving order
        for (int i = 0; i < list.Count; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < result.Count; j++)
            {
                if (list[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                result.Add(list[i]);
            }
        }

        Console.WriteLine("List after removing duplicates:");
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}
