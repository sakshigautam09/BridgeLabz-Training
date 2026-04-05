class InPatient : Patient
{
    public int DaysAdmitted { get; private set; }
    public double DailyRoomCharge { get; private set; }
    public double SurgeryCost { get; private set; }

    public InPatient(string name, int age, int daysAdmitted, double dailyRoomCharge, double surgeryCost)
        : base(name, age)
    {
        DaysAdmitted = daysAdmitted;
        DailyRoomCharge = dailyRoomCharge;
        SurgeryCost = surgeryCost;
    }

    public override double CalculateBill()
    {
        double medicineCharges = 1000;
        return (DaysAdmitted * DailyRoomCharge) + SurgeryCost + medicineCharges;
    }
}
