using System;
class EmployeeBonus
{
    static double[,] GenerateEmployeeData(int employees)
    {
        Random rand = new Random();
        double[,] data = new double[employees, 2];

        for (int i = 0; i < employees; i++)
        {
            data[i, 0] = rand.Next(10000, 100000); // salary
            data[i, 1] = rand.Next(1, 11);        // years
        }
        return data;
    }

    static double[,] CalculateBonus(double[,] data)
    {
        int employees = data.GetLength(0);
        double[,] result = new double[employees, 2];

        for (int i = 0; i < employees; i++)
        {
            double salary = data[i, 0];
            double years = data[i, 1];

            double bonusRate = (years > 5) ? 0.05 : 0.02;
            double bonus = salary * bonusRate;
            double newSalary = salary + bonus;

            result[i, 0] = newSalary;
            result[i, 1] = bonus;
        }
        return result;
    }

    static void DisplayResult(double[,] oldData, double[,] newData)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");

        for (int i = 0; i < oldData.GetLength(0); i++)
        {
            double oldSalary = oldData[i, 0];
            double years = oldData[i, 1];
            double newSalary = newData[i, 0];
            double bonus = newData[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine($"{i + 1}\t{oldSalary}\t{years}\t{bonus:F2}\t{newSalary:F2}");
        }
        Console.WriteLine($"Total Old Salary : {totalOldSalary:F2}");
        Console.WriteLine($"Total Bonus      : {totalBonus:F2}");
        Console.WriteLine($"Total New Salary : {totalNewSalary:F2}");
    }

    static void Main()
    {
        int employees = 10;
        double[,] employeeData = GenerateEmployeeData(employees);
        double[,] updatedData = CalculateBonus(employeeData);
        DisplayResult(employeeData, updatedData);
    }
}
