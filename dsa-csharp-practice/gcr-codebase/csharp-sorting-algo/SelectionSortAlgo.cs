using System;

public sealed class SelectionSortAlgo
{
    // Selection Sort function
    public static void SelectionSort(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // Find the index of the minimum element in the unsorted part
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum with the first unsorted element
            if (minIndex != i)
            {
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }
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
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] examScores = new int[n];

        // Input exam scores
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter score for student {i + 1}: ");
            examScores[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nExam Scores Before Selection Sort:");
        Display(examScores);

        SelectionSort(examScores);

        Console.WriteLine("\nExam Scores After Selection Sort (Ascending Order):");
        Display(examScores);
    }
}
