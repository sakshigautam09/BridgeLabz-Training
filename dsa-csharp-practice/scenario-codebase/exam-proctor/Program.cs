class Program
{
    static void Main()
    {
        // Sample correct answers
        Dictionary<int, string> correctAnswers = new Dictionary<int, string>()
        {
            {1, "A"},
            {2, "B"},
            {3, "C"},
            {4, "D"},
            {5, "A"}
        };

        ExamProctor student = new ExamProctor(correctAnswers);

        // Student navigates and answers
        student.VisitQuestion(1);
        student.AnswerQuestion(1, "A");

        student.VisitQuestion(2);
        student.AnswerQuestion(2, "C");

        student.VisitQuestion(3);
        student.AnswerQuestion(3, "C");

        student.GoBack(); //goes back 
        student.AnswerQuestion(3, "C"); 

        student.VisitQuestion(4);
        student.AnswerQuestion(4, "D");

        student.VisitQuestion(5);
        student.AnswerQuestion(5, "B");

        // Display answers
        student.DisplayAnswers();

        // Calculate score
        int score = student.CalculateScore();
        Console.WriteLine($"\nTotal Score: {score}/{correctAnswers.Count}");
    }
}
