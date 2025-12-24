using System;
class AmarAkbarAnthony
{
    static void Main()
    {
        int[] age = new int[3];
        double[] height = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter Age: ");
            age[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Height: ");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }
        int youngest_idx = 0;
        int tallest_idx = 0;

        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngest_idx])
                youngest_idx = i;

            if (height[i] > height[tallest_idx])
                tallest_idx = i;
        }
        Console.WriteLine("Youngest Friend: " + names[youngest_idx]);
        Console.WriteLine("Tallest Friend: " + names[tallest_idx]);
    }
}
