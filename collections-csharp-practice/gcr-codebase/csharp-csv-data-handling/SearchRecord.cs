using System;
using System.IO;

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

    public string GetName()
    {
        return name;
    }

    public void DisplayDepartmentAndSalary()
    {
        Console.WriteLine("Department : " + department);
        Console.WriteLine("Salary     : " + salary);
    }
}

class EmployeeSearcher
{
    private string filePath;

    // Constructor
    public EmployeeSearcher(string filePath)
    {
        this.filePath = filePath;
    }

    public void SearchByName(string searchName)
    {
        bool found = false;

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

                Employee emp = new Employee(id, name, department, salary);

                if (emp.GetName().Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Employee Found!");
                    emp.DisplayDepartmentAndSalary();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error: Unable to read the CSV file.");
        }
    }
}

class SearchRecord
{
    static void Main()
    {
        EmployeeSearcher searcher = new EmployeeSearcher("employees.csv");
        searcher.SearchByName("Neha");
    }
}
