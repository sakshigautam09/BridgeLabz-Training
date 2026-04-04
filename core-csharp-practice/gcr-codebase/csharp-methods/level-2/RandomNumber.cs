using System;
class RandomNumber
{
    static int[] GenerateArr(int size)
    {
        Random r = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = r.Next(1000, 10000);
        return arr;
    }
    static double[] FindAvgMinMax(int[] arr)
    {
        int min = arr[0], max = arr[0], sum = 0;
        foreach (int n in arr)
        {
            sum += n;
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }
        return new double[] { (double)sum / arr.Length, min, max };
    }
    static void Main()
    {
        int[] arr = GenerateArr(5);
        double[] ans = FindAvgMinMax(arr);
        Console.WriteLine("Average: " + ans[0]);
        Console.WriteLine("Min: " + ans[1]);
        Console.WriteLine("Max: " + ans[2]);
    }
}
