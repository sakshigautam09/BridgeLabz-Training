using System;

sealed class EmployeeMenu
{
    private IEmployee emp;

    public void EmployeeChoices()
    {
        emp = new EmployeeUtilityImpl();

        Employee employee = new Employee();
        employee.EmployeeId = 101;
        employee.EmployeeName = "John";

        emp.AddEmployee(employee);
        emp.CheckAttendance(employee);

        Console.WriteLine(employee);
    }
}
