using System;
class Student
{
    // Static variables
    public static string UniversityName = "GLA University";
    private static int totalStudents = 0;

    // Readonly variable (cannot be changed)
    public readonly int RollNumber;

    // Instance variables
    public string Name;
    public string Grade;

    // Constructor
    public Student(int rollNumber, string name, string grade)
    {
        this.RollNumber = rollNumber;   // using this to refer to instance variable
        this.Name = name;
        this.Grade = grade;

        totalStudents++;   // increment total students whenever a new student is created
    }

    // Instance method to display student details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Roll Number: {RollNumber}, Grade: {Grade}, University: {UniversityName}");
    }

    // Static method to display total students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine($"Total Students Enrolled: {totalStudents}");
    }
}
class UniversityStudentManagement
{
    static void Main()
    {
        Console.WriteLine("University Student Management");
        // Creating students
        Student s1 = new Student(101, "sakshi", "A");
        Student s2 = new Student(102, "gautam", "B");

        if (s1 is Student)
        {
            s1.DisplayDetails(); 
        }

        // Display all students
        s1.DisplayDetails();
        s2.DisplayDetails();
        Console.WriteLine();
        DisplayTotalStudents();

        // s1.RollNumber = 500; // Not allowed (because it is read only)
    }
}
