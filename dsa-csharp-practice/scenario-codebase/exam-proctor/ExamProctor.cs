using System;
using System.Collections.Generic;

class ExamProctor
{
    // Stack -> for last visited question
    private Stack<int> navigationStack = new Stack<int>();

    // Dictionary: QuestionID -> Answer
    private Dictionary<int, string> answersMap = new Dictionary<int, string>();

    // Dictionary to store correct answers
    private Dictionary<int, string> correctAnswers = new Dictionary<int, string>();

    public ExamProctor(Dictionary<int, string> correctAnswers)
    {
        this.correctAnswers = correctAnswers;
    }

    // Function to navigate to a question
    public void VisitQuestion(int questionID)
    {
        navigationStack.Push(questionID);
        Console.WriteLine($"Visited Question {questionID}");
    }

    // Function to answer a question
    public void AnswerQuestion(int questionID, string answer)
    {
        if (answersMap.ContainsKey(questionID))
            answersMap[questionID] = answer; // update answer
        else
            answersMap.Add(questionID, answer);

        Console.WriteLine($"Answered Question {questionID}: {answer}");
    }

    // Function to go back to last visited question
    public void GoBack()
    {
        if (navigationStack.Count > 0)
        {
            int lastQuestion = navigationStack.Pop();
            Console.WriteLine($"Going back to Question {lastQuestion}");
        }
        else
        {
            Console.WriteLine("No previous question to go back to.");
        }
    }

    // Function to calculate score
    public int CalculateScore()
    {
        int score = 0;

        foreach (var q in correctAnswers)
        {
            if (answersMap.ContainsKey(q.Key) && answersMap[q.Key].Equals(q.Value, StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }

        return score;
    }

    // Display student's answers
    public void DisplayAnswers()
    {
        Console.WriteLine("\nStudent's Answers:");
        foreach (var kvp in answersMap)
        {
            Console.WriteLine($"Q{kvp.Key} -> {kvp.Value}");
        }
    }
}