using System;

public class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private int workHours;
    private double hourlyRate;

    public PartTimeEmployee(int employeeId, string name, double hourlyRate, int workHours)
        : base(employeeId, name, 0)
    {
        this.hourlyRate = hourlyRate;
        this.workHours = workHours;
    }

    public override double CalculateSalary()
    {
        return workHours * hourlyRate;
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
