using System;

class Program
{
    static void Main()
    {
        Patient[] patients = new Patient[3];
        MedicalRecordManager[] records = new MedicalRecordManager[3];

        patients[0] = new InPatient("Alice", 30, 5, 2000, 15000);
        patients[1] = new OutPatient("Bob", 25, 3, 1500);
        patients[2] = new InPatient("Charlie", 40, 7, 1800, 20000);

        records[0] = new MedicalRecordManager();
        records[0].AddRecord("CBC - Normal");

        records[1] = new MedicalRecordManager();
        records[1].AddRecord("MRI Scan - Pending");

        records[2] = new MedicalRecordManager();
        records[2].AddRecord("Surgery Scheduled - Knee Replacement");

        Console.WriteLine("=== Hospital Patient Management System ===\n");

        for (int i = 0; i < patients.Length; i++)
        {
            patients[i].GetPatientDetails();

            double bill = patients[i].CalculateBill();
            Console.WriteLine("Total Bill: " + bill);

            records[i].ViewRecords();
            Console.WriteLine();
        }
    }
}
