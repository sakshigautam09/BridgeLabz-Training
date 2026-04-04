using System;

class StudentScoreAnalyzer
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());
        int[] scores = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Enter score for student {i + 1}: ");
                try
                {
                    int score = int.Parse(Console.ReadLine());
                    if (score < 0)
                    {
                        Console.WriteLine("* Invalid input! Enter a non-negative number.");
                        continue;
                    }
                    scores[i] = score;
                    break; // valid input, exit loop
                }
                catch
                {
                    Console.WriteLine("* Invalid input! Enter a numeric value.");
                }
            }
        }
        FindMinMax(scores);
        double average = CalculateAverage(scores);
        Console.WriteLine($"Average score: {average:F2}");
        PrintAboveAverage(scores, average);
    }
    static void FindMinMax(int[] scores)
    {
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int score in scores)
        {
            if (score < min) min = score;
            if (score > max) max = score;
        }
        Console.WriteLine($"Highest score: {max}");
        Console.WriteLine($"Lowest score: {min}");
    }
    static double CalculateAverage(int[] scores)
    {
        int sum = 0;
        foreach (int score in scores)
            sum += score;
        return (double)sum / scores.Length;
    }

    static void PrintAboveAverage(int[] scores, double average)
    {
        Console.WriteLine("Scores above average:");
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > average)
                Console.WriteLine($"Student {i + 1}: {scores[i]}");
        }
    }
}