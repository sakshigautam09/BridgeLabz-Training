using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    private int id;
    private string name;
    private int age;
    private int marks;

    // Constructor
    public Student(int id, string name, int age, int marks)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.marks = marks;
    }

    // Method to display student data
    public void Display()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Marks: " + marks);
    }
}

class CSVReader
{
    private string filePath;

    // Constructor
    public CSVReader(string filePath)
    {
        this.filePath = filePath;
    }

    // Method to read CSV file
    public List<Student> ReadStudents()
    {
        List<Student> students = new List<Student>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            // Start from index 1 to skip header
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                int id = Convert.ToInt32(data[0]);
                string name = data[1];
                int age = Convert.ToInt32(data[2]);
                int marks = Convert.ToInt32(data[3]);

                Student student = new Student(id, name, age, marks);
                students.Add(student);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error: CSV file not found.");
        }

        return students;
    }
}

class ReadCsvFile
{
    static void Main()
    {
        CSVReader reader = new CSVReader("students.csv");
        List<Student> students = reader.ReadStudents();

        foreach (Student student in students)
        {
            student.Display();
        }
    }
}
