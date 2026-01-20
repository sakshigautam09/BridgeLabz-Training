using System;

public class AssignmentCourse : CourseType
{
    public AssignmentCourse() : base("Assignments") { }

    public override void Evaluate()
    {
        Console.WriteLine("Evaluated using assignments and projects");
    }
}
