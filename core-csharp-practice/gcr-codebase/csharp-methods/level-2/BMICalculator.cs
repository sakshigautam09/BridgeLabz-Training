using System;
class BMICalculator
{
    static void CalcBMI(double[,] data)
    {
        for (int i = 0; i < 10; i++)
        {
            double ht = data[i, 1] / 100;
            data[i, 2] = data[i, 0] / (ht * ht);
        }
    }
    static string GetStatus(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        if (bmi < 25) return "Normal";
        if (bmi < 30) return "Overweight";
        return "Obese";
    }

    static void Main()
    {
        double[,] data = new double[10, 3];
        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = double.Parse(Console.ReadLine());
            data[i, 1] = double.Parse(Console.ReadLine());
        }

        CalcBMI(data);
        for (int i = 0; i < 10; i++)
            Console.WriteLine($"BMI: {data[i, 2]:F2} Status: {GetStatus(data[i, 2])}");
    }
}
