using System;
class MedicalRecordManager : IMedicalRecord
{
    private string record1;
    private string record2;
    private string record3;
    private int recordCount = 0;

    public void AddRecord(string record)
    {
        recordCount++;
        if (recordCount == 1) record1 = record;
        else if (recordCount == 2) record2 = record;
        else if (recordCount == 3) record3 = record;
        else Console.WriteLine("Maximum 3 records allowed.");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        if (!string.IsNullOrEmpty(record1)) Console.WriteLine("- " + record1);
        if (!string.IsNullOrEmpty(record2)) Console.WriteLine("- " + record2);
        if (!string.IsNullOrEmpty(record3)) Console.WriteLine("- " + record3);
    }
}
