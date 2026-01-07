using System;

class EmployeeUtilityImpl : IEmployee
{
    private const int WAGE_PER_HOUR = 20;
    private const int FULL_DAY_HOUR = 8;
    private const int PART_TIME_HOUR = 8;
    private const int MAX_WORKING_DAYS = 20;
    private const int MAX_WORKING_HOURS = 100;

    public Employee AddEmployee(Employee employee)
    {
        return employee;
    }

    public void CheckAttendance(Employee employee)
    {
        Random random = new Random();
        int attendance = random.Next(0, 2);
        employee.IsPresent = attendance == 1;
    }

    public void CalculateDailyWage(Employee employee)
    {
        int dailyWage = 0;
        if (employee.IsPresent)
        {
            dailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
        }

        Console.WriteLine("Employee Id: " + employee.EmployeeId);
        Console.WriteLine("Employee Name: " + employee.EmployeeName);
        Console.WriteLine("Attendance: " + (employee.IsPresent ? "Present" : "Absent"));
        Console.WriteLine("Daily Wage (Full-Time): " + dailyWage);
    }

    public void CalculatePartTimeWage(Employee employee)
    {
        int wage = 0;
        if (employee.IsPresent)
        {
            wage = WAGE_PER_HOUR * PART_TIME_HOUR;
        }

        Console.WriteLine("Employee Id: " + employee.EmployeeId);
        Console.WriteLine("Employee Name: " + employee.EmployeeName);
        Console.WriteLine("Attendance: " + (employee.IsPresent ? "Present" : "Absent"));
        Console.WriteLine("Part-Time Wage: " + wage);
    }

    public void CalculateMonthlyWage(Employee employee)
    {
        int totalWage = 0;
        Random random = new Random();

        Console.WriteLine("\nCalculating Monthly Wage for Employee Id: " + employee.EmployeeId +
                          ", Name: " + employee.EmployeeName);

        for (int day = 1; day <= MAX_WORKING_DAYS; day++)
        {
            int attendance = random.Next(0, 2);
            bool isPresent = attendance == 1;

            int dailyWage = 0;

            if (isPresent)
            {
                dailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
            }

            totalWage += dailyWage;
            Console.WriteLine("Day " + day + ": " + (isPresent ? "Present" : "Absent") +
                              " | Daily Wage: " + dailyWage);
        }

        Console.WriteLine("Total Monthly Wage: " + totalWage);
    }

    public void CalculateWageTillCondition(Employee employee)
    {
        int totalHours = 0;
        int totalWage = 0;
        int workingDays = 0;
        Random random = new Random();

        Console.WriteLine("\nCalculating Wages Till Condition for Employee Id: " + employee.EmployeeId +
                          ", Name: " + employee.EmployeeName);

        while (totalHours < MAX_WORKING_HOURS && workingDays < MAX_WORKING_DAYS)
        {
            workingDays++;
            int attendance = random.Next(0, 2);
            bool isPresent = attendance == 1;

            int hoursWorked = isPresent ? FULL_DAY_HOUR : 0;
            int dailyWage = hoursWorked * WAGE_PER_HOUR;

            totalHours += hoursWorked;
            totalWage += dailyWage;

            Console.WriteLine("Day " + workingDays + ": " + (isPresent ? "Present" : "Absent") +
                              " | Hours Worked: " + hoursWorked +
                              " | Daily Wage: " + dailyWage);
        }

        Console.WriteLine("Total Days Worked: " + workingDays);
        Console.WriteLine("Total Hours Worked: " + totalHours);
        Console.WriteLine("Total Wage: " + totalWage);
    }
}
