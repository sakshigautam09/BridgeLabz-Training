using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class JsonReport
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Rahul", Department = "IT" },
            new Employee { Id = 2, Name = "Pooja", Department = "HR" }
        };

        string report = JsonConvert.SerializeObject(employees, Formatting.Indented);
        File.WriteAllText("EmployeeReport.json", report);

        Console.WriteLine("JSON Report Generated");
    }
}
