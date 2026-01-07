using System;

sealed class EmployeeMenu
{
    private IEmployee emp;

    public void EmployeeChoices()
    {
        emp = new EmployeeUtilityImpl();

        Employee employee = new Employee();

        Console.Write("Enter Employee Id: ");
        employee.EmployeeId = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        employee.EmployeeName = Console.ReadLine();

        // Check Attendance (UC-1)
        emp.AddEmployee(employee);
        emp.CheckAttendance(employee);

        // Ask type of employee
        Console.Write("Enter 1 for Full-Time, 2 for Part-Time: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            // UC-2: Full-Time Daily Wage
            emp.CalculateDailyWage(employee);
        }
        else if (choice == 2)
        {
            // UC-3: Part-Time Wage
            emp.CalculatePartTimeWage(employee);
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
    }
}
