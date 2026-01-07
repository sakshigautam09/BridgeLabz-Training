class OutPatient : Patient
{
    public int NumberOfVisits { get; private set; }
    public double VisitCharge { get; private set; }

    public OutPatient(string name, int age, int numberOfVisits, double visitCharge)
        : base(name, age)
    {
        NumberOfVisits = numberOfVisits;
        VisitCharge = visitCharge;
    }

    public override double CalculateBill()
    {
        double consultationFee = 500;
        return (NumberOfVisits * VisitCharge) + consultationFee;
    }
}
