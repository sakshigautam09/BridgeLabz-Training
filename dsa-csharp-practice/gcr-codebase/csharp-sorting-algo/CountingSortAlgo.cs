using System;

public sealed class CountingSortAlgo
{
    // Counting Sort function
    public static void CountingSort(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int n = ages.Length;
        int[] output = new int[n];

        // Count occurrences
        for (int i = 0; i < n; i++)
        {
            count[ages[i] - minAge]++;
        }

        // Cumulative count
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }

        // Place elements into output array
        for (int i = n - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        // Copy sorted array back to original
        for (int i = 0; i < n; i++)
        {
            ages[i] = output[i];
        }
    }

    // Display array
    private static void Display(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    // Main method
    public static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] studentAges = new int[n];

        // Input ages
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter age of student {i + 1} (10-18): ");
            studentAges[i] = int.Parse(Console.ReadLine());
            if (studentAges[i] < 10 || studentAges[i] > 18)
            {
                Console.WriteLine("Invalid age! Please enter between 10 and 18.");
                i--; // retry
            }
        }

        Console.WriteLine("\nStudent Ages Before Counting Sort:");
        Display(studentAges);

        CountingSort(studentAges, 10, 18);

        Console.WriteLine("\nStudent Ages After Counting Sort (Ascending Order):");
        Display(studentAges);
    }
}
