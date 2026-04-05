using System;
class SearchTargetIn2D
{
    static void Main()
    {
        Console.Write("Rows: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Columns: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Target value to search: ");
        int target = int.Parse(Console.ReadLine());

        bool found = SearchMatrix(matrix, target);
        Console.WriteLine(found ? "Target found in matrix." : "Target not found in matrix.");
    }

    static bool SearchMatrix(int[,] matrix, int target)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            int left = 0, right = n - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (matrix[i, mid] == target)
                    return true;
                else if (matrix[i, mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }
        return false;
    }
}
