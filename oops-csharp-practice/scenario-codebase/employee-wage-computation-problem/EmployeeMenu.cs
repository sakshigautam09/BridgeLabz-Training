using System;

sealed class EmployeeMenu
{
    private IEmployee emp;

    public void ShowMenu()
    {
        emp = new EmployeeUtilityImpl();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n===== Employee Menu =====");
            Console.WriteLine("1. Full-Time Employee Daily Wage");
            Console.WriteLine("2. Part-Time Employee Daily Wage");
            Console.WriteLine("3. Monthly Wage (Full-Time)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    HandleFullTimeEmployee();
                    break;

                case 2:
                    HandlePartTimeEmployee();
                    break;

                case 3:
                    HandleMonthlyWage();
                    break;

                case 4:
                    exit = true;
                    Console.WriteLine("Exiting Menu...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private void HandleFullTimeEmployee()
    {
        Employee employee = ReadEmployeeDetails();
        emp.AddEmployee(employee);
        emp.CheckAttendance(employee);
        emp.CalculateDailyWage(employee);
    }

    private void HandlePartTimeEmployee()
    {
        Employee employee = ReadEmployeeDetails();
        emp.AddEmployee(employee);
        emp.CheckAttendance(employee);
        emp.CalculatePartTimeWage(employee);
    }

    private void HandleMonthlyWage()
    {
        Employee employee = ReadEmployeeDetails();
        emp.AddEmployee(employee);
        emp.CalculateMonthlyWage(employee);
    }

    private Employee ReadEmployeeDetails()
    {
        Employee employee = new Employee();
        Console.Write("Enter Employee Id: ");
        employee.EmployeeId = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        employee.EmployeeName = Console.ReadLine();

        return employee;
    }
}
