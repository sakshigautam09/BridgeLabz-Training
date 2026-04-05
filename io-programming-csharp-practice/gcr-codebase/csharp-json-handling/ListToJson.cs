using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class ListToJson
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Aman" },
            new Student { Id = 2, Name = "Neha" }
        };

        string jsonArray = JsonConvert.SerializeObject(students, Formatting.Indented);
        Console.WriteLine(jsonArray);
    }
}
