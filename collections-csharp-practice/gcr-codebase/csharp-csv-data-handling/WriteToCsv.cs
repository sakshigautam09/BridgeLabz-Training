using System;
using System.IO;
using System.Collections.Generic;

class Employee
{
    private int id;
    private string name;
    private string department;
    private double salary;

    // Constructor
    public Employee(int id, string name, string department, double salary)
    {
        this.id = id;
        this.name = name;
        this.department = department;
        this.salary = salary;
    }

    // Convert employee data to CSV format
    public string ToCSV()
    {
        return id + "," + name + "," + department + "," + salary;
    }
}

class CSVWriter
{
    private string filePath;

    // Constructor
    public CSVWriter(string filePath)
    {
        this.filePath = filePath;
    }

    public void WriteEmployees(List<Employee> employees)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    // Write header
                    writer.WriteLine("ID,Name,Department,Salary");

                    // Write records
                    foreach (Employee emp in employees)
                    {
                        writer.WriteLine(emp.ToCSV());
                    }
                }
            }

            Console.WriteLine("Employee data written to CSV successfully.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error while writing to CSV file.");
        }
    }
}

class WriteToCsv
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee(1, "Amit", "IT", 60000));
        employees.Add(new Employee(2, "Neha", "HR", 45000));
        employees.Add(new Employee(3, "Rohan", "Finance", 52000));
        employees.Add(new Employee(4, "Pooja", "Marketing", 48000));
        employees.Add(new Employee(5, "Karan", "Operations", 50000));

        CSVWriter writer = new CSVWriter("employees.csv");
        writer.WriteEmployees(employees);
    }
}
