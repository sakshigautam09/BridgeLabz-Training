using System;
class Student
{
    // Public member
    public int rollNumber;
    // Protected member
    protected string name;
    // Private member
    private double CGPA;

    // Constructor
    public Student(int roll, string n, double cgpa)
    {
        rollNumber = roll;
        name = n;
        CGPA = cgpa;
    }
    // Public method to get CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public method to set CGPA
    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }

    // Method to display basic details
    public void DisplayStudent()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("CGPA: " + CGPA);
    }
}

// Subclass to demonstrate protected access
class PostgraduateStudent : Student
{
    public string specialization;

    public PostgraduateStudent(int roll, string n, double cgpa, string spec)
        : base(roll, n, cgpa)
    {
        specialization = spec;
    }

    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber); // public
        Console.WriteLine("Name: " + name);              // protected
        Console.WriteLine("Specialization: " + specialization);
        Console.WriteLine("CGPA: " + GetCGPA());          // accessed via public method
    }
}

class UniversityManagementSystem
{
    static void Main()
    {
        Student s1 = new Student(101, "Amit", 8.5);
        s1.DisplayStudent();

        Console.WriteLine();

        // Modify CGPA using public method
        s1.SetCGPA(8.8);
        Console.WriteLine("Updated CGPA: " + s1.GetCGPA());

        Console.WriteLine();

        PostgraduateStudent pg = new PostgraduateStudent(201, "Neha", 9.1, "Computer Science");
        pg.DisplayPostgraduateDetails();
    }
}
