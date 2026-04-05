using System;
class Course
{
    // Instance variables
    public string courseName;
    public int duration;     // in months
    public double fee;

    // Class variable (shared)
    public static string instituteName = "BridgeLabz";

    // Constructor
    public Course(string name, int d, double f)
    {
        courseName = name;
        duration = d;
        fee = f;
    }

    // Instance method
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute: " + instituteName);
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: ₹" + fee);
    }

    // Class (static) method
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
}
class OnlineCourseManagement
{
    static void Main()
    {
        Course c1 = new Course("C#", 3, 30000);
        Course c2 = new Course("Java", 4, 35000);

        c1.DisplayCourseDetails();
        Console.WriteLine();
        c2.DisplayCourseDetails();

        Console.WriteLine("\nUpdating Institute Name...\n");
        Course.UpdateInstituteName("BridgeLabz Solutions");

        c1.DisplayCourseDetails();
        Console.WriteLine();
        c2.DisplayCourseDetails();
    }
}
