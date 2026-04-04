using System;
class GradeCalculation
{
    static void Main()
    {
        double phy, chem, math;

        Console.Write("Enter physics marks: ");
        phy = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter chemistry marks: ");
        chem = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter maths marks: ");
        math = Convert.ToDouble(Console.ReadLine());

        double avg = (phy + chem + math) / 3;

        Console.WriteLine("Average Marks = " + avg);

        if (avg >= 90)
            Console.WriteLine("Grade A : Excellent");
        else if (avg >= 75)
            Console.WriteLine("Grade B : Very Good");
        else if (avg >= 60)
            Console.WriteLine("Grade C : Good");
        else if (avg >= 40)
            Console.WriteLine("Grade D : Pass");
        else
            Console.WriteLine("Grade F : Fail");
    }
}
