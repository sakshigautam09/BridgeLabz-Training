abstract class LoanApplication : IApprovable
    {
    protected int term;              // months
    protected double interestRate;
    private bool approved;

    protected LoanApplication(int term, double interestRate)
    {
        this.term = term;
        this.interestRate = interestRate;
    }

    protected void SetApproved(bool status)
    {
        approved = status;
    }

    public bool IsApproved()
    {
        return approved;
    }

    protected double EmiFormula(double principal)
    {
        double r = interestRate / (12 * 100);
        int n = term;
        return (principal * r * Math.Pow(1 + r, n)) /
               (Math.Pow(1 + r, n) - 1);
    }

    public abstract bool ApproveLoan(Applicant applicant);
    public abstract double CalculateEMI(Applicant applicant);
}