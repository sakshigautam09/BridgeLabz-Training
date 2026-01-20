class Program
{
    static void Main()
    {
        Course<ExamCourse> mathCourse = new Course<ExamCourse>("Mathematics");
        mathCourse.AddCourseType(new ExamCourse());

        Course<AssignmentCourse> csCourse = new Course<AssignmentCourse>("Computer Science");
        csCourse.AddCourseType(new AssignmentCourse());

        mathCourse.DisplayEvaluationMethods();
        csCourse.DisplayEvaluationMethods();
    }
}
