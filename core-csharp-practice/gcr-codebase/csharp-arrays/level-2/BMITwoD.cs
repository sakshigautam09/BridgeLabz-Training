using System;
class BMITwoD
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double[][] personData = new double[n][];
        string[] weightStatus = new string[n];
        for (int i = 0; i < n; i++)
        {
            personData[i] = new double[3];
        }
        for (int i = 0; i < n; i++)
        {
            personData[i][0] = Convert.ToDouble(Console.ReadLine());
            personData[i][1] = Convert.ToDouble(Console.ReadLine());
            if (personData[i][0] <= 0 || personData[i][1] <= 0)
            {
                Console.WriteLine("Invalid input");
                i--;
            }
        }
        for (int i = 0; i < n; i++)
        {
            personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);

            if (personData[i][2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i][2] < 25)
                weightStatus[i] = "Normal";
            else if (personData[i][2] < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(personData[i][1] + " " + personData[i][0] + " " + Math.Round(personData[i][2], 2) + " " + weightStatus[i]);
        }
    }
}
