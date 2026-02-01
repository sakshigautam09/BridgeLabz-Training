using System;
using System.IO;
using System.Collections.Generic;

class Employee
{
    private int id;
    private string name;
    private string department;
    private double salary;

    public Employee(int id, string name, string department, double salary)
    {
        this.id = id;
        this.name = name;
        this.department = department;
        this.salary = salary;
    }

    public string ToCSV()
    {
        return id + "," + name + "," + department + "," + salary;
    }
}

class CSVReportGenerator
{
    private string filePath;

    public CSVReportGenerator(string filePath)
    {
        this.filePath = filePath;
    }

    public void GenerateReport(List<Employee> employees)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write header
                writer.WriteLine("Employee ID,Name,Department,Salary");

                // Write employee records
                foreach (Employee emp in employees)
                {
                    writer.WriteLine(emp.ToCSV());
                }
            }

            Console.WriteLine("CSV report generated successfully.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error writing CSV report.");
        }
    }
}

class GenerateCsv
{
    static void Main()
    {
        // Simulated database data
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee(1, "Amit", "IT", 60000));
        employees.Add(new Employee(2, "Neha", "HR", 45000));
        employees.Add(new Employee(3, "Rohan", "Finance", 52000));
        employees.Add(new Employee(4, "Pooja", "Marketing", 48000));
        employees.Add(new Employee(5, "Karan", "IT", 70000));

        CSVReportGenerator reportGenerator =
            new CSVReportGenerator("employee_report.csv");

        reportGenerator.GenerateReport(employees);
    }
}
