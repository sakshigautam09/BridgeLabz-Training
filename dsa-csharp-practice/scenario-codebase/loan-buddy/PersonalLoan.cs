class PersonalLoan : LoanApplication
{
    public PersonalLoan(int term, double interestRate)
        : base(term, interestRate) { }

    public override bool ApproveLoan(Applicant a)
    {
        bool status = a.CreditScore >= 650 && a.Income >= 25000;
        SetApproved(status);
        return status;
    }

    public override double CalculateEMI(Applicant a)
    {
        return EmiFormula(a.LoanAmount);
    }
}