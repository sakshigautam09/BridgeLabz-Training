using System;
class Marks
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] marks = new int[n][];
        double[] percentage = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            marks[i] = new int[3];
        }
        for (int i = 0; i < n; i++)
        {
            marks[i][0] = Convert.ToInt32(Console.ReadLine());
            marks[i][1] = Convert.ToInt32(Console.ReadLine());
            marks[i][2] = Convert.ToInt32(Console.ReadLine());
            if (marks[i][0] < 0 || marks[i][1] < 0 || marks[i][2] < 0)
            {
                Console.WriteLine("Negative marks");
                i--;  
            }
        }
        for (int i = 0; i < n; i++)
        {
            int total = marks[i][0] + marks[i][1] + marks[i][2];
            percentage[i] = total / 3.0;
            if (percentage[i] >= 90)
                grade[i] = "A";
            else if (percentage[i] >= 75)
                grade[i] = "B";
            else if (percentage[i] >= 60)
                grade[i] = "C";
            else if (percentage[i] >= 40)
                grade[i] = "D";
            else
                grade[i] = "Fail";
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(marks[i][0] + " " + marks[i][1] + " " + marks[i][2] + " " + percentage[i] + " " + grade[i]);
        }
    }
}
