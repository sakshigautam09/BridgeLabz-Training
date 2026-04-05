class HomeLoan : LoanApplication
{
    public HomeLoan(int term, double interestRate)
        : base(term, interestRate) { }

    public override bool ApproveLoan(Applicant a)
    {
        bool status = a.CreditScore >= 700 && a.Income >= 50000;
        SetApproved(status);
        return status;
    }

    public override double CalculateEMI(Applicant a)
    {
        return EmiFormula(a.LoanAmount) * 0.95; // subsidy benefit
    }
}