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

    // Display method
    public void Display()
    {
        Console.WriteLine("ID    : " + id);
        Console.WriteLine("Name  : " + name);
        Console.WriteLine("Age   : " + age);
        Console.WriteLine("Marks : " + marks);
        Console.WriteLine("----------------------");
    }
}

class CSVStudentReader
{
    private string filePath;

    // Constructor
    public CSVStudentReader(string filePath)
    {
        this.filePath = filePath;
    }

    public List<Student> ReadStudents()
    {
        List<Student> students = new List<Student>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false; // skip header
                        continue;
                    }

                    string[] data = line.Split(',');

                    int id = int.Parse(data[0]);
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    int marks = int.Parse(data[3]);

                    Student student = new Student(id, name, age, marks);
                    students.Add(student);
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading CSV file.");
        }

        return students;
    }
}

class ConvertCsvToJava
{
    static void Main()
    {
        CSVStudentReader reader = new CSVStudentReader("students.csv");
        List<Student> students = reader.ReadStudents();

        foreach (Student student in students)
        {
            student.Display();
        }
    }
}
