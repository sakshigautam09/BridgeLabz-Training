using System;
class StudentQuizGrader
{
    static string[] questions;
    static string[] correctAnswers;
    static string[] studentAnswers;

    static bool questionsAdded = false;
    static bool answersEntered = false;

    static bool isTeacherAuthenticated = false;
    const string TEACHER_PASSKEY = "teacher123";

    public static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== EDUQUIZ MENU ===");
            Console.WriteLine("1. Add Questions");
            Console.WriteLine("2. View Questions");
            Console.WriteLine("3. Answer Quiz");
            Console.WriteLine("4. View Result");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddQuestions();
                    break;

                case 2:
                    DisplayQuestions();
                    break;

                case 3:
                    EnterStudentAnswers();
                    break;

                case 4:
                    ShowResult();
                    break;

                case 5:
                    exit = true;
                    Console.WriteLine("Thank you for using EduQuiz.");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    private static void AddQuestions()
    {
        if (!isTeacherAuthenticated)
        {
            Console.Write("Enter teacher passkey: ");
            string pass = Console.ReadLine();

            if (pass != TEACHER_PASSKEY)
            {
                Console.WriteLine("Access denied. Only teacher can add questions.");
                return;
            }

            isTeacherAuthenticated = true;
            Console.WriteLine("Teacher authenticated.");
        }

        Console.Write("How many questions? ");
        int count = Convert.ToInt32(Console.ReadLine());

        questions = new string[count];
        correctAnswers = new string[count];
        studentAnswers = new string[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter Question {i + 1}: ");
            questions[i] = Console.ReadLine();

            Console.Write("Enter correct answer: ");
            correctAnswers[i] = Console.ReadLine();
        }

        questionsAdded = true;
        answersEntered = false;

        Console.WriteLine("Questions added successfully.");
    }

    private static void DisplayQuestions()
    {
        if (!questionsAdded)
        {
            Console.WriteLine("No questions available.");
            return;
        }

        Console.WriteLine("\n--- QUESTIONS ---");
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Q{i + 1}: {questions[i]}");
        }
    }

    private static void EnterStudentAnswers()
    {
        if (!questionsAdded)
        {
            Console.WriteLine("Quiz not prepared yet.");
            return;
        }
        Console.WriteLine("\n--- START QUIZ ---");

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"\nQuestion {i + 1}: {questions[i]}");
            Console.Write("Your answer: ");
            studentAnswers[i] = Console.ReadLine();
        }
        answersEntered = true;
        Console.WriteLine("\nQuiz completed successfully.");
        }

    private static void ShowResult()
    {
        if (!answersEntered)
        {
            Console.WriteLine("Please answer the quiz first.");
            return;
        }

        int score = CalculateScore(correctAnswers, studentAnswers);
        int total = correctAnswers.Length;
        double percentage = (score * 100.0) / total;

        Console.WriteLine("\n--- RESULT ---");
        for (int i = 0; i < total; i++)
        {
            if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Question {i + 1}: Correct");
            else
                Console.WriteLine($"Question {i + 1}: Incorrect");
        }

        Console.WriteLine($"Score: {score}/{total}");
        Console.WriteLine($"Percentage: {percentage}%");

        Console.WriteLine(percentage >= 40 ? "Status: PASS" : "Status: FAIL");
    }

    private static int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;

        for (int i = 0; i < correct.Length; i++)
        {
            if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }

        return score;
    }
}
