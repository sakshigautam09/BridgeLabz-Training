using System;

public class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int employeeId, string name, double baseSalary)
        : base(employeeId, name, baseSalary)
    {
    }

    public override double CalculateSalary()
    {
        // Full-time employees get base salary
        return BaseSalary;
    }

    public void AssignDepartment(string departmentName)
    {
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return "Department: " + department;
    }
}
