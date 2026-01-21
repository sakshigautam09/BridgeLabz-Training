using System;
using System.Collections.Generic;
public class RotateList
{
    static void Main()
    {
        List<int> list = new List<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Enter rotation count: ");
        int k = int.Parse(Console.ReadLine());

        k = k % n; 

        // // store first k elements
        // int[] temp = new int[k];
        // for (int i = 0; i < k; i++)
        // {
        //     temp[i] = list[i];
        // }

        // // shift elements left
        // for (int i = k; i < n; i++)
        // {
        //     list[i - k] = list[i];
        // }

        // // add stored elements at end
        // int index = n - k;
        // for (int i = 0; i < k; i++)
        // {
        //     list[index++] = temp[i];
        // }

        // Console.WriteLine("Rotated List:");
        // for (int i = 0; i < list.Count; i++)
        // {
        //     Console.Write(list[i] + " ");
        // }

// second method
        Reverse(list, 0, k - 1);
        Reverse(list, k, n - 1);
        Reverse(list, 0, n - 1);

        Console.WriteLine("Rotated List:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
    }

    static void Reverse(List<int> list, int start, int end)
    {
        while (start < end)
        {
            int temp = list[start];
            list[start] = list[end];
            list[end] = temp;
            start++;
            end--;
        }
    }
}
