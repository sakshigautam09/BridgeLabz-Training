using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Employee
{
    private int id;
    private string name;
    private string department;
    private string email;
    private double salary;

    public Employee(int id, string name, string department, string email, double salary)
    {
        this.id = id;
        this.name = name;
        this.department = department;
        this.email = email;
        this.salary = salary;
    }

    public string GetEncryptedCSV()
    {
        return id + "," +
               name + "," +
               department + "," +
               EncryptionHelper.Encrypt(email) + "," +
               EncryptionHelper.Encrypt(salary.ToString());
    }

    public static Employee FromEncryptedCSV(string line)
    {
        string[] data = line.Split(',');

        int id = int.Parse(data[0]);
        string name = data[1];
        string department = data[2];
        string email = EncryptionHelper.Decrypt(data[3]);
        double salary = double.Parse(EncryptionHelper.Decrypt(data[4]));

        return new Employee(id, name, department, email, salary);
    }

    public void Display()
    {
        Console.WriteLine(id + " | " + name + " | " + department + " | " + email + " | " + salary);
    }
}

class EncryptionHelper
{
    public static string Encrypt(string plainText)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(plainText);
        return Convert.ToBase64String(bytes);
    }

    public static string Decrypt(string cipherText)
    {
        byte[] bytes = Convert.FromBase64String(cipherText);
        return Encoding.UTF8.GetString(bytes);
    }
}

class CSVHandler
{
    private string filePath;

    public CSVHandler(string filePath)
    {
        this.filePath = filePath;
    }

    public void WriteEncryptedCSV(List<Employee> employees)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Id,Name,Department,Email,Salary");

            foreach (Employee emp in employees)
            {
                writer.WriteLine(emp.GetEncryptedCSV());
            }
        }

        Console.WriteLine("Encrypted CSV written successfully.");
    }

    public void ReadAndDecryptCSV()
    {
        string[] lines = File.ReadAllLines(filePath);

        Console.WriteLine("\nDecrypted Data:");
        for (int i = 1; i < lines.Length; i++)
        {
            Employee emp = Employee.FromEncryptedCSV(lines[i]);
            emp.Display();
        }
    }
}

class EncryptDecryptCsv
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee(1, "Amit", "IT", "amit@gmail.com", 60000));
        employees.Add(new Employee(2, "Neha", "HR", "neha@gmail.com", 50000));
        employees.Add(new Employee(3, "Rohan", "Finance", "rohan@gmail.com", 70000));

        CSVHandler handler = new CSVHandler("employees_secure.csv");

        handler.WriteEncryptedCSV(employees);
        handler.ReadAndDecryptCSV();
    }
}
