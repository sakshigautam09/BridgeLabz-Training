using System;
public class Applicant
{
    private string name;
    private int creditScore;
    private int income;
    private int loanAmount;

    public void Applicant(string name, int creditScore, int income, int loanAmount)
    {
        this.name = name;
        this.creditScore = creditScore;
        this.income = income;
        this.loanAmount = loanAmount;
    }
    public string GetName()
    {
        return name;
    }
    public int GetCreditScore()
    {
        return creditScore;
    }
    public int GetIncome()
    {
        return income;
    }
    public int GetLoanAmount()
    {
        return loanAmount;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
}