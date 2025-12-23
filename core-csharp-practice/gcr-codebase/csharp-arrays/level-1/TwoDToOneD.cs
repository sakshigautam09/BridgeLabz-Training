using System;
class TwoDToOneD
{
    public static void Main(string[] args)
    {
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int[] arr = new int[rows * cols];
        int idx = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.toInt32(Console.ReadLine());
                arr[idx++] = matrix[i, j];
            }
        }

        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
}
