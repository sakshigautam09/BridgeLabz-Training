using System;
using System.IO;

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

    public int GetMarks()
    {
        return marks;
    }

    public void Display()
    {
        Console.WriteLine("ID    : " + id);
        Console.WriteLine("Name  : " + name);
        Console.WriteLine("Age   : " + age);
        Console.WriteLine("Marks : " + marks);
        Console.WriteLine("---------------------");
    }
}

class CSVStudentFilter
{
    private string filePath;

    // Constructor
    public CSVStudentFilter(string filePath)
    {
        this.filePath = filePath;
    }

    public void PrintStudentsWithMarksAbove80()
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                string[] data = lines[i].Split(',');

                int id = Convert.ToInt32(data[0]);
                string name = data[1];
                int age = Convert.ToInt32(data[2]);
                int marks = Convert.ToInt32(data[3]);

                Student student = new Student(id, name, age, marks);

                if (student.GetMarks() > 80)
                {
                    student.Display();
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error: Unable to read the CSV file.");
        }
    }
}

class FilterRecords
{
    static void Main()
    {
        CSVStudentFilter filter = new CSVStudentFilter("students.csv");
        filter.PrintStudentsWithMarksAbove80();
    }
}
