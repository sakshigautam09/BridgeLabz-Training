using System;
public class InsertionSortAlgo
{
    // Insertion Sort function
    public static void Insertion(int[] employeeIds)
    {
        for (int i = 1; i < employeeIds.Length; i++)
        {
            int key = employeeIds[i];
            int j = i - 1;

            // Shift elements of sorted part to the right
            while (j >= 0 && employeeIds[j] > key)
            {
                employeeIds[j + 1] = employeeIds[j];
                j--;
            }

            // Insert element at correct position
            employeeIds[j + 1] = key;
        }
    }

    // Display function
    public static void Display(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    // Main method
    public static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        int[] employeeIds = new int[n];

        // Input Employee IDs
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter Employee ID {i + 1}: ");
            employeeIds[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nEmployee IDs Before Sorting:");
        Display(employeeIds);

        Insertion(employeeIds);

        Console.WriteLine("\nEmployee IDs After Insertion Sort (Ascending Order):");
        Display(employeeIds);
    }
}
