using System;
class Hospital
{
    static void Main()
    {
        Patient inPatient = new InPatient(1, "Amit", 45, 5, 2000);
        Patient outPatient = new OutPatient(2, "Neha", 30, 500);

        Doctor doctor = new Doctor(101, "Dr. Sharma", "Cardiology");

        doctor.DisplayDoctorInfo();
        Console.WriteLine();

        inPatient.DisplayInfo();
        Bill inBill = new Bill(inPatient);
        inBill.PrintBill();

        Console.WriteLine();

        outPatient.DisplayInfo();
        Bill outBill = new Bill(outPatient);
        outBill.PrintBill();
    }
}
