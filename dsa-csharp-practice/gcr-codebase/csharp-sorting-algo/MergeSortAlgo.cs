using System;

public sealed class MergeSortAlgo
{
    // Merge Sort function
    public static void MergeSort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            // Divide
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);

            // Merge the two halves
            Merge(prices, left, mid, right);
        }
    }

    // Merge helper function
    private static void Merge(int[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = prices[left + i];

        for (int j = 0; j < n2; j++)
            rightArray[j] = prices[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        // Merge two sorted arrays
        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
                prices[k++] = leftArray[iIndex++];
            else
                prices[k++] = rightArray[jIndex++];
        }

        // Copy remaining elements
        while (iIndex < n1)
            prices[k++] = leftArray[iIndex++];

        while (jIndex < n2)
            prices[k++] = rightArray[jIndex++];
    }

    // Display function
    private static void Display(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    // Main method
    public static void Main()
    {
        Console.Write("Enter the number of books: ");
        int n = int.Parse(Console.ReadLine());

        int[] bookPrices = new int[n];

        // Input book prices
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter price for book {i + 1}: ");
            bookPrices[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nBook Prices Before Merge Sort:");
        Display(bookPrices);

        MergeSort(bookPrices, 0, bookPrices.Length - 1);

        Console.WriteLine("\nBook Prices After Merge Sort (Ascending Order):");
        Display(bookPrices);
    }
}
