using System;
using System.Collections;
using System.Collections.Generic;

public class ReverseAList
{
    static void Main()
    {
        ReverseArrayList();
        ReverseLinkedList();
    }

    public static void ReverseArrayList()
    {
        ArrayList arrList = new ArrayList();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arrList.Add(int.Parse(Console.ReadLine()));
        }

        int left = 0;
        int right = arrList.Count - 1;

        while (left < right)
        {
            object temp = arrList[left];
            arrList[left] = arrList[right];
            arrList[right] = temp;

            left++;
            right--;
        }

        Console.WriteLine("Reversed ArrayList:");
        for (int i = 0; i < arrList.Count; i++)
        {
            Console.Write(arrList[i] + " ");
        }

        Console.WriteLine();
    }

    public static void ReverseLinkedList()
    {
        LinkedList<int> list = new LinkedList<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            list.AddLast(int.Parse(Console.ReadLine()));
        }

        LinkedList<int> reversedList = new LinkedList<int>();
        foreach (int value in list)
        {
            reversedList.AddFirst(value);
        }

        Console.WriteLine("Reversed LinkedList:");
        foreach (int value in reversedList)
        {
            Console.Write(value + " ");
        }
    }
}
