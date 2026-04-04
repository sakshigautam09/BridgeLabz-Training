using System;
class HeightOfPlayers
{
    public static void Main(string[] args)
    {
        double[] heights = new double[11];
        double sum = 0.0;
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }

        double mean = sum / heights.Length;
        Console.WriteLine("Mean height of the football team = " + mean);
    }
}
