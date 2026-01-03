using System;
class Patient
{
    // static variable
    public static string HospitalName = "City Care Hospital";
    private static int totalPatients = 0;

    // readonly variable
    public readonly int PatientID;

    // instance variables
    public string Name;
    public int Age;
    public string Ailment;

    // constructor using this
    public Patient(int patientId, string name, int age, string ailment)
    {
        this.PatientID = patientId;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;

        totalPatients++;
    }

    // static method to get total patients
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }

    // instance method
    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {PatientID}, Name: {Name}, Age: {Age}, Ailment: {Ailment}, Hospital: {HospitalName}");
    }
}

class HospitalManagementSystem
{
    static void Main()
    {
        Patient p1 = new Patient(1, "Sita", 30, "Fever");
        Patient p2 = new Patient(2, "Aman", 45, "Diabetes");

        // using is operator
        if (p1 is Patient)
        {
            p1.DisplayDetails();
        }

        p1.DisplayDetails();
        p2.DisplayDetails();

        GetTotalPatients();
    }
}
