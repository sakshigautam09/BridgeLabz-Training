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

    public void IncreaseSalaryBy10Percent()
    {
        salary = salary + (salary * 0.10);
    }

    public string GetDepartment()
    {
        return department;
    }

    public string ToCSV()
    {
        return id + "," + name + "," + department + "," + salary;
    }
}

class CSVEmployeeUpdater
{
    private string inputFile;
    private string outputFile;

    // Constructor
    public CSVEmployeeUpdater(string inputFile, string outputFile)
    {
        this.inputFile = inputFile;
        this.outputFile = outputFile;
    }

    public void UpdateSalaries()
    {
        try
        {
            string[] lines = File.ReadAllLines(inputFile);

            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    // Write header
                    writer.WriteLine(lines[0]);

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] data = lines[i].Split(',');

                        int id = Convert.ToInt32(data[0]);
                        string name = data[1];
                        string department = data[2];
                        double salary = Convert.ToDouble(data[3]);

                        Employee emp = new Employee(id, name, department, salary);

                        if (emp.GetDepartment().Equals("IT", StringComparison.OrdinalIgnoreCase))
                        {
                            emp.IncreaseSalaryBy10Percent();
                        }

                        writer.WriteLine(emp.ToCSV());
                    }
                }
            }

            Console.WriteLine("Salary updated successfully. New file created.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error while reading or writing CSV file.");
        }
    }
}

class ModifyCsv
{
    static void Main()
    {
        CSVEmployeeUpdater updater =
            new CSVEmployeeUpdater("employees.csv", "updated_employees.csv");

        updater.UpdateSalaries();
    }
}
