using System;

class FirstNegative
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        // Input array elements
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int firstIdx = -1;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] < 0)
            {
                firstIdx = i;
                break;  // stop
            }
        }
        if (firstIdx != -1)
        {
            Console.WriteLine($"First negative number is {arr[firstIdx]} at index {firstIdx}.");
        }
        else
        {
            Console.WriteLine("No negative number found in the array.");
        }
    }
}
