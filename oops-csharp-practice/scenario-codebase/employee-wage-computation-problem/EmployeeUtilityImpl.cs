using System;

class EmployeeUtilityImpl : IEmployee
{
    private const int WAGE_PER_HOUR = 20;
    private const int FULL_DAY_HOUR = 8;

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
        Console.WriteLine("Daily Wage: " + dailyWage);
    }
}
