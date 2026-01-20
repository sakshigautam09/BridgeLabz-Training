using System;

public abstract class CourseType
{
    public string EvaluationMethod { get; }

    protected CourseType(string evaluationMethod)
    {
        EvaluationMethod = evaluationMethod;
    }

    public abstract void Evaluate();
}
