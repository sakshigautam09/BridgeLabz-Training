using System;
class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Employee Salary: " + Salary);
    }
}
class EmployeeDetails
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.Name = "sakshi";
        employee.Id = 101;
        employee.Salary = 50000;

        employee.DisplayDetails();
    }
}