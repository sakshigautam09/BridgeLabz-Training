using System;

class CheckNumber
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine($"{arr[i]} is Positive and Even");
                }
                else
                {
                    Console.WriteLine($"{arr[i]} is Positive and Odd");
                }
            }
            else if (arr[i] < 0)
            {
                Console.WriteLine($"{arr[i]} is Negative");
            }
            else
            {
                Console.WriteLine($"{arr[i]} is Zero");
            }
        }

        // Comparing first and last elements
        if (arr[0] == arr[arr.Length - 1])
        {
            Console.WriteLine("First and last elements are equal");
        }
        else if (arr[0] > arr[arr.Length - 1])
        {
            Console.WriteLine("First element is greater than last element");
        }
        else
        {
            Console.WriteLine("First element is less than last element");
        }
    }
}
