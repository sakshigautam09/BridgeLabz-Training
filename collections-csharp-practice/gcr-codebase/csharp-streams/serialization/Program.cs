using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Program
{
    static void Main()
    {
        string filePath = "employees.json";

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amit", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Neha", Department = "HR", Salary = 45000 }
        };

        // Serialize
        try
        {
            string jsonData = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Employees saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error during serialization: " + ex.Message);
        }

        // Deserialize
        try
        {
            string jsonFromFile = File.ReadAllText(filePath);
            List<Employee> loadedEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonFromFile);

            Console.WriteLine("\nEmployees from file:");
            foreach (var emp in loadedEmployees)
            {
                Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Department} | {emp.Salary}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error during deserialization: " + ex.Message);
        }
    }
}
