using System;
class BonusCalculation
{
    static void Main()
    {
        int n = 10;
        double[] salary = new double[n];
        double[] years = new double[n];
        double[] bonus = new double[n];
        double[] newSalary = new double[n];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        for (int i = 0; i < n; i++){
            salary[i] = Convert.ToDouble(Console.ReadLine());
            years[i] = Convert.ToDouble(Console.ReadLine());

            if (salary[i] <= 0 || years[i] < 0)
            {
                Console.WriteLine("Invalid input.");
                i--;
                continue;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (years[i] > 5)
            {
                bonus[i] = salary[i] * 0.05;
            }
            else
            {
                bonus[i] = salary[i] * 0.02;
            }

            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total Bonus Paid: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
