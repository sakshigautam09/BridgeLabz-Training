using System;
class Employee
{
    public int employeeID;       // public
    protected string department; // protected
    private double salary;       // private

    // Constructor
    public Employee(int id, string dept, double sal)
    {
        employeeID = id;
        department = dept;
        salary = sal;
    }

    // Public method to modify salary
    public void SetSalary(double sal)
    {
        salary = sal;
    }

    // Public method to get salary
    public double GetSalary()
    {
        return salary;
    }

    // Display method
    public void DisplayEmployee()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: ₹" + salary);
    }
}

// Subclass
class Manager : Employee
{
    public string managerLevel;

    public Manager(int id, string dept, double sal, string level)
        : base(id, dept, sal)
    {
        managerLevel = level;
    }

    public void DisplayManager()
    {
        Console.WriteLine("Employee ID: " + employeeID);     // public
        Console.WriteLine("Department: " + department);     // protected
        Console.WriteLine("Manager Level: " + managerLevel);
        Console.WriteLine("Salary: ₹" + GetSalary());       // private via public method
    }
}
class EmployeeRecords
{
    static void Main()
    {
        Employee e1 = new Employee(101, "HR", 50000);
        e1.DisplayEmployee();

        Console.WriteLine();

        // Modify salary
        e1.SetSalary(55000);
        Console.WriteLine("Updated Employee Salary: ₹" + e1.GetSalary());

        Console.WriteLine();

        Manager m1 = new Manager(201, "IT", 90000, "Senior");
        m1.DisplayManager();
    }
}
