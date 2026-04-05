using System;
public class BubbleSortAlgo
{
    // Bubble Sort function
    public static void Bubble(int[] marks)
    {
        int n = marks.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    // Swap
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    // Display function
    public static void Display(int[] marks)
    {
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write(marks[i] + " ");
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] studentMarks = new int[n];

        // Input marks
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter marks for student {i + 1}: ");
            studentMarks[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nStudent Marks Before Sorting:");
        Display(studentMarks);

        Bubble(studentMarks);

        Console.WriteLine("\nStudent Marks After Bubble Sort (Ascending Order):");
        Display(studentMarks);
    }
}
