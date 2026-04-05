class AutoLoan : LoanApplication
{
    public AutoLoan(int term, double interestRate)
        : base(term, interestRate) { }

    public override bool ApproveLoan(Applicant a)
    {
        bool status = a.CreditScore >= 680;
        SetApproved(status);
        return status;
    }

    public override double CalculateEMI(Applicant a)
    {
        return EmiFormula(a.LoanAmount);
    }
}