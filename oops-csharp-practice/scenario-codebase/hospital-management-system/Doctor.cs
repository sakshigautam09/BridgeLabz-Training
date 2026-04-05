public class Doctor
{
    private int doctorId;
    private string name;
    private string specialization;

    public Doctor(int doctorId, string name, string specialization)
    {
        this.doctorId = doctorId;
        this.name = name;
        this.specialization = specialization;
    }

    public void DisplayDoctorInfo()
    {
        Console.WriteLine("---- Doctor Details ----");
        Console.WriteLine($"ID: {doctorId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Specialization: {specialization}");
    }
}
