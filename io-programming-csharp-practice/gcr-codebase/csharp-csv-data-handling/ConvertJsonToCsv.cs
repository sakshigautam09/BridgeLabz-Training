using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Student
{
    public int Id;
    public string Name;
    public int Age;
    public int Marks;

    public Student() { }

    public Student(int id, string name, int age, int marks)
    {
        Id = id;
        Name = name;
        Age = age;
        Marks = marks;
    }

    public string ToCSV()
    {
        return Id + "," + Name + "," + Age + "," + Marks;
    }
}

class FileConverter
{
    private string jsonPath;
    private string csvPath;

    public FileConverter(string jsonPath, string csvPath)
    {
        this.jsonPath = jsonPath;
        this.csvPath = csvPath;
    }

    // JSON → CSV
    public void ConvertJsonToCsv()
    {
        string jsonData = File.ReadAllText(jsonPath);

        List<Student> students =
            JsonSerializer.Deserialize<List<Student>>(jsonData);

        using (StreamWriter writer = new StreamWriter(csvPath))
        {
            writer.WriteLine("Id,Name,Age,Marks");

            foreach (Student s in students)
            {
                writer.WriteLine(s.ToCSV());
            }
        }

        Console.WriteLine("JSON converted to CSV successfully.");
    }

    // CSV → JSON
    public void ConvertCsvToJson(string outputJsonPath)
    {
        List<Student> students = new List<Student>();
        string[] lines = File.ReadAllLines(csvPath);

        for (int i = 1; i < lines.Length; i++) // skip header
        {
            string[] data = lines[i].Split(',');

            Student s = new Student(
                int.Parse(data[0]),
                data[1],
                int.Parse(data[2]),
                int.Parse(data[3])
            );

            students.Add(s);
        }

        string jsonOutput =
            JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText(outputJsonPath, jsonOutput);

        Console.WriteLine("CSV converted back to JSON successfully.");
    }
}

class ConvertJsonToCsv
{
    static void Main()
    {
        FileConverter converter =
            new FileConverter("students.json", "students.csv");

        converter.ConvertJsonToCsv();
        converter.ConvertCsvToJson("students_converted.json");
    }
}
