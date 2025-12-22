using System;
class BonusCalculation
{
    static void Main()
    {
        int salary;
        int years;
        double bonus = 0;
        Console.Write("Enter salary: ");
        salary = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter years: ");
        years = Convert.ToInt32(Console.ReadLine());

        if (years > 5)
        {
            bonus = salary * 0.05;
            Console.WriteLine("Bonus amount is " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus");
        }
    }
}
