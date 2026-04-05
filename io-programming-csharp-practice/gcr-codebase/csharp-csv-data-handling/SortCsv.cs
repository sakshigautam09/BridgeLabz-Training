using System;
using System.IO;
using System.Collections.Generic;

class Employee : IComparable<Employee>
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

    // Compare salary for descending order
    public int CompareTo(Employee other)
    {
        return other.salary.CompareTo(this.salary);
    }

    public void Display()
    {
        Console.WriteLine("ID         : " + id);
        Console.WriteLine("Name       : " + name);
        Console.WriteLine("Department : " + department);
        Console.WriteLine("Salary     : " + salary);
        Console.WriteLine("---------------------------");
    }
}

class CSVEmployeeSorter
{
    private string filePath;

    // Constructor
    public CSVEmployeeSorter(string filePath)
    {
        this.filePath = filePath;
    }

    public List<Employee> ReadEmployees()
    {
        List<Employee> employees = new List<Employee>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                string[] data = lines[i].Split(',');

                int id = Convert.ToInt32(data[0]);
                string name = data[1];
                string department = data[2];
                double salary = Convert.ToDouble(data[3]);

                employees.Add(new Employee(id, name, department, salary));
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading CSV file.");
        }

        return employees;
    }
}

class SortCsv
{
    static void Main()
    {
        CSVEmployeeSorter sorter = new CSVEmployeeSorter("employees.csv");
        List<Employee> employees = sorter.ReadEmployees();

        employees.Sort();

        Console.WriteLine("Top 5 Highest-Paid Employees:\n");

        int count = employees.Count < 5 ? employees.Count : 5;

        for (int i = 0; i < count; i++)
        {
            employees[i].Display();
        }
    }
}
