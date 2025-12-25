using System;
class FootballTeam
{
    static int Sum(int[] heights)
    {
        int sum = 0;
        for (int i = 0; i < heights.Length; i++)
            sum += heights[i];
        return sum;
    }

    static double Mean(int[] heights)
    {
        return (double)Sum(heights) / heights.Length;
    }

    static int Shortest(int[] heights)
    {
        int min = heights[0];
        for (int i = 1; i < heights.Length; i++)
            if (heights[i] < min) {
                min = heights[i];
            }
        return min;
    }

    static int Tallest(int[] heights)
    {
        int max = heights[0];
        for (int i = 1; i < heights.Length; i++)
            if (heights[i] > max) {
                max = heights[i];
            }
        return max;
    }

    static void Main()
    {
        int[] heights = new int[11];
        Random r = new Random();
        for (int i = 0; i < heights.Length; i++)
            heights[i] = r.Next(150, 251);

        Console.WriteLine("Sum: " + Sum(heights));
        Console.WriteLine("Shortest: " + Shortest(heights));
        Console.WriteLine("Tallest: " + Tallest(heights));
        Console.WriteLine("Mean Height: " + Mean(heights));
    }
}
