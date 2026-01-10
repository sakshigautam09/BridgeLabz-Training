using System;

public sealed class HeapSortAlgo
{
    // Heap Sort function
    public static void HeapSort(int[] salaries)
    {
        int n = salaries.Length;

        // Build max heap
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(salaries, n, i);

        // Extract elements from heap one by one
        for (int i = n - 1; i > 0; i--)
        {
            // Move current root to end
            Swap(salaries, 0, i);

            // Call max heapify on the reduced heap
            Heapify(salaries, i, 0);
        }
    }

    // Heapify function (max heap)
    private static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;       // Initialize largest as root
        int left = 2 * i + 1;  // left child
        int right = 2 * i + 2; // right child

        // If left child is larger
        if (left < n && arr[left] > arr[largest])
            largest = left;

        // If right child is larger
        if (right < n && arr[right] > arr[largest])
            largest = right;

        // If largest is not root
        if (largest != i)
        {
            Swap(arr, i, largest);

            // Recursively heapify the affected subtree
            Heapify(arr, n, largest);
        }
    }

    // Swap helper function
    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
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
        Console.Write("Enter the number of applicants: ");
        int n = int.Parse(Console.ReadLine());

        int[] salaries = new int[n];

        // Input salaries
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter expected salary for applicant {i + 1}: ");
            salaries[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nSalaries Before Heap Sort:");
        Display(salaries);

        HeapSort(salaries);

        Console.WriteLine("\nSalaries After Heap Sort (Ascending Order):");
        Display(salaries);
    }
}
