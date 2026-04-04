using System;
class BMICalculator
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            weight[i] = Convert.ToDouble(Console.ReadLine());
            height[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            bmi[i] = weight[i] / (height[i] * height[i]);
            if (bmi[i] < 18.5)
                status[i] = "Underweight";
            else if (bmi[i] < 25)
                status[i] = "Normal";
            else if (bmi[i] < 30)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(height[i] + " " + weight[i] + " " + Math.Round(bmi[i], 2) + " " +status[i]);
        }
    }
}
