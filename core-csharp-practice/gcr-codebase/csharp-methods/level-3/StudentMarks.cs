using System;
class StudentMarks
{
    public static int[,] StudentArr(int students)
    {
        int[,] scores = new int[students, 3];
        Random rand = new Random();

        for (int i = 0; i < students; i++)
        {
            scores[i, 0] = rand.Next(10, 100); // phy
            scores[i, 1] = rand.Next(10, 100); // chem
            scores[i, 2] = rand.Next(10, 100); // math
        }
        return scores;
    }

    public static double[,] CalculateResults(int[,] scores)
    {
        int students = scores.GetLength(0);
        double[,] results = new double[students, 3];

        for (int i = 0; i < students; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;

            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    public static void Display(int[,] scores, double[,] results)
    {
        Console.WriteLine("\nStudent\tPhysics\tChem\tMaths\tTotal\tAverage\tPercentage");

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.WriteLine((i + 1) + "\t" +
                scores[i, 0] + "\t" +
                scores[i, 1] + "\t" +
                scores[i, 2] + "\t" +
                results[i, 0] + "\t" +
                results[i, 1] + "\t" +
                results[i, 2]);
        }
    }
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        int[,] scores = StudentArr(students);

        double[,] results = CalculateResults(scores);
        Display(scores, results);
    }
}
