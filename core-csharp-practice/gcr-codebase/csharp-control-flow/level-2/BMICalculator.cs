using System;
class BMICalculator
{
    static void Main()
    {
        double weight, height_cm;
        Console.Write("Enter weight: ");
        weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        heightCm = Convert.ToDouble(Console.ReadLine());

        double height_m = height_cm / 100;
        double bmi = weight / (height_m * height_m);

        Console.WriteLine("BMI = " + bmi);

        if (bmi < 18.5)
            Console.WriteLine("Underweight");
        else if (bmi < 25)
            Console.WriteLine("Normal");
        else if (bmi < 30)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
    }
}
