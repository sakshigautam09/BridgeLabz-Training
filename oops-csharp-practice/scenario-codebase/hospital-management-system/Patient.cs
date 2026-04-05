public abstract class Patient : IPayable
{
    private int patientId;
    private string name;
    private int age;

    protected Patient(int patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public int PatientId
    {
        get { return patientId; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Age
    {
        get { return age; }
    }

    public abstract void DisplayInfo();

    public abstract double CalculateBill();
}
