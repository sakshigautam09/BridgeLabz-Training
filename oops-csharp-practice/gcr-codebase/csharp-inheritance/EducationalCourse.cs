using System;
class Course
{
    public string CourseName;
    public int Duration; 

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " hours");
    }
}

class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Recorded: " + (IsRecorded ? "Yes" : "No"));
    }
}

class PaidOnlineCourse : OnlineCourse
{
    public double Fee;
    public double Discount;

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Course Fee: ₹" + Fee);
        Console.WriteLine("Discount: " + Discount + "%");
        Console.WriteLine("Final Fee: ₹" + (Fee - (Fee * Discount / 100)));
    }
}

class EducationalCourse
{
    static void Main()
    {
        Course c = new Course("Programming Basics", 20);
        Course oc = new OnlineCourse("C# Online Course", 30, "Udemy", true);
        Course poc = new PaidOnlineCourse("Advanced C#", 40, "Coursera", true, 5000, 20);

        c.DisplayDetails();
        Console.WriteLine();

        oc.DisplayDetails();
        Console.WriteLine();

        poc.DisplayDetails();
    }
}
