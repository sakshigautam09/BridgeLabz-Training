using System;
class Employee
{
    // static variable
    public static string CompanyName = "BridgeLabz Pvt Ltd";
    private static int totalEmployees = 0;
    // readonly variable
    public readonly int Id;

    // instance variables
    public string Name;
    public string Designation;

    // Constructor using 'this'
    public Employee(int id, string name, string designation)
    {
        this.Id = id;               // readonly assigned once
        this.Name = name;           // resolves ambiguity
        this.Designation = designation;
        totalEmployees++;
    }

    // static method
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    // instance method
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Company Name: " + CompanyName);
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Designation: " + Designation);
    }
}
class EmployeeManagementSystem
{
    static void Main()
    {
        Employee e1 = new Employee(101, "Amit", "Developer");
        Employee e2 = new Employee(102, "Neha", "Tester");

        Console.WriteLine();
        if (e1 is Employee)
        {
            Console.WriteLine("e1 is an Employee object");
            e1.DisplayEmployeeDetails();
        }
        Console.WriteLine();
        if (e2 is Employee)
        {
            Console.WriteLine("e2 is an Employee object");
            e2.DisplayEmployeeDetails();
        }

        Console.WriteLine();
        // Static method call
        Employee.DisplayTotalEmployees();
    }
}
