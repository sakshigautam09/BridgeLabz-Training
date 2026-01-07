using System;

sealed class EmployeeMenu
{
    private IEmployee emp;

    public void EmployeeChoices()
    {
        emp = new EmployeeUtilityImpl();

        // Read Employee Details from user
        Employee employee = new Employee();

        Console.Write("Enter Employee Id: ");
        employee.EmployeeId = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        employee.EmployeeName = Console.ReadLine();

        // UC-1: Check Attendance
        emp.AddEmployee(employee);
        emp.CheckAttendance(employee);

        // UC-2: Calculate Daily Wage
        emp.CalculateDailyWage(employee);
    }
}
