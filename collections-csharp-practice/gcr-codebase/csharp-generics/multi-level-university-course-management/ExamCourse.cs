using System;

public class ExamCourse : CourseType
{
    public ExamCourse() : base("Written Exam") { }

    public override void Evaluate()
    {
        Console.WriteLine("Evaluated using final written exam");
    }
}
