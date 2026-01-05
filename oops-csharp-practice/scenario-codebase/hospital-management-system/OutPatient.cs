public class OutPatient : Patient
{
    private double consultationFee;

    public OutPatient(int patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("---- OutPatient Details ----");
        Console.WriteLine($"ID: {PatientId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Consultation Fee: {CalculateBill()}");
    }
}
