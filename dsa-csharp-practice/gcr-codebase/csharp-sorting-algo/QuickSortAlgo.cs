using System;

public sealed class QuickSortAlgo
{
    // Quick Sort function
    public static void QuickSort(int[] prices, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(prices, low, high);

            // Recursively sort left and right partitions
            QuickSort(prices, low, pivotIndex - 1);
            QuickSort(prices, pivotIndex + 1, high);
        }
    }

    // Partition function
    private static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high]; // choosing last element as pivot
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (prices[j] <= pivot)
            {
                i++;
                Swap(prices, i, j);
            }
        }

        Swap(prices, i + 1, high);
        return i + 1;
    }

    // Swap function
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
        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());

        int[] productPrices = new int[n];

        // Input product prices
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter price for product {i + 1}: ");
            productPrices[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nProduct Prices Before Quick Sort:");
        Display(productPrices);

        QuickSort(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("\nProduct Prices After Quick Sort (Ascending Order):");
        Display(productPrices);
    }
}
