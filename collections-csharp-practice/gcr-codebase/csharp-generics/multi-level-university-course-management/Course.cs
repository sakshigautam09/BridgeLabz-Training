using System;
using System.Collections.Generic;

public class Course<T> where T : CourseType
{
    public string CourseName { get; }
    private List<T> courseTypes = new List<T>();

    public Course(string courseName)
    {
        CourseName = courseName;
    }

    public void AddCourseType(T type)
    {
        courseTypes.Add(type);
    }

    public void DisplayEvaluationMethods()
    {
        Console.WriteLine($"\nCourse: {CourseName}");
        foreach (T type in courseTypes)
        {
            Console.WriteLine($"Evaluation: {type.EvaluationMethod}");
            type.Evaluate();
        }
    }
}
