public class InPatient : Patient
{
    private int numberOfDays;
    private double dailyCharge;

    public InPatient(int patientId, string name, int age, int numberOfDays, double dailyCharge)
        : base(patientId, name, age)
    {
        this.numberOfDays = numberOfDays;
        this.dailyCharge = dailyCharge;
    }

    public override double CalculateBill()
    {
        return numberOfDays * dailyCharge;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("---- InPatient Details ----");
        Console.WriteLine($"ID: {PatientId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Days Admitted: {numberOfDays}");
        Console.WriteLine($"Total Bill: {CalculateBill()}");
    }
}
