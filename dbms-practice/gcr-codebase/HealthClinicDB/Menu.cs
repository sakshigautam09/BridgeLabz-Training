using System;
using System.Collections.Generic;

public class Menu
{
    PatientUtility patientUtility = new PatientUtility();
    DoctorUtility doctorUtility = new DoctorUtility();
    AppointmentUtility appointmentUtility = new AppointmentUtility();
    VisitUtility visitUtility = new VisitUtility();
    BillingUtility billingUtility = new BillingUtility();
    AdminUtility adminUtility = new AdminUtility();

    public void Show()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("\n--- HEALTH CLINIC SYSTEM ---");
                Console.WriteLine("1. Patient Module");
                Console.WriteLine("2. Doctor Module");
                Console.WriteLine("3. Appointment Module");
                Console.WriteLine("4. Visit & Medical Records");
                Console.WriteLine("5. Billing Module");
                Console.WriteLine("6. System Administration");
                Console.WriteLine("7. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: PatientMenu(); break;
                    case 2: DoctorMenu(); break;
                    case 3: AppointmentMenu(); break;
                    case 4: VisitMenu(); break;
                    case 5: BillingMenu(); break;
                    case 6: AdminMenu(); break;
                    case 7: Environment.Exit(0); break;
                    default: Console.WriteLine("Invalid choice. Try again."); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter numbers where required.");
            }
            catch (ClinicException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }

    private void PatientMenu()
    {
        try
        {
            Console.WriteLine("\n--- PATIENT MENU ---");
            Console.WriteLine("1. Register Patient");
            Console.WriteLine("2. Update Patient");
            Console.WriteLine("3. Delete Patient");
            Console.WriteLine("4. View All Patients");
            Console.WriteLine("5. Search Patient");
            Console.WriteLine("6. View Patient Visit History");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Name: "); string name = Console.ReadLine();
                    Console.Write("DOB (yyyy-MM-dd): "); DateTime dob = DateTime.Parse(Console.ReadLine());
                    Console.Write("Phone: "); string phone = Console.ReadLine();
                    Console.Write("Email: "); string email = Console.ReadLine();
                    Console.Write("Address: "); string address = Console.ReadLine();
                    Console.Write("Blood Group: "); string blood = Console.ReadLine();
                    Console.Write("Doctor ID: "); int doctorId = Convert.ToInt32(Console.ReadLine());

                    patientUtility.AddPatient(name, dob, phone, email, address, blood, doctorId);
                    break;

                case 2:
                    Console.Write("Patient ID: "); int pid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: "); string pname = Console.ReadLine();
                    Console.Write("DOB (yyyy-MM-dd): "); DateTime pdob = DateTime.Parse(Console.ReadLine());
                    Console.Write("Phone: "); string pphone = Console.ReadLine();
                    Console.Write("Email: "); string pemail = Console.ReadLine();
                    Console.Write("Address: "); string paddress = Console.ReadLine();
                    Console.Write("Blood Group: "); string pblood = Console.ReadLine();
                    Console.Write("Doctor ID: "); int pdoctorId = Convert.ToInt32(Console.ReadLine());

                    patientUtility.UpdatePatient(pid, pname, pdob, pphone, pemail, paddress, pblood, pdoctorId);
                    break;

                case 3:
                    Console.Write("Patient ID: "); int deleteId = Convert.ToInt32(Console.ReadLine());
                    patientUtility.DeletePatient(deleteId);
                    break;

                case 4:
                    patientUtility.GetAllPatients();
                    break;

                case 5:
                    Console.Write("Search (Name/ID/Phone): "); string search = Console.ReadLine();
                    patientUtility.SearchPatient(search);
                    break;

                case 6:
                    Console.Write("Patient ID: "); int historyId = Convert.ToInt32(Console.ReadLine());
                    patientUtility.GetPatientVisitHistory(historyId);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter correct data types.");
        }
        catch (ClinicException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }

    private void DoctorMenu()
    {
        try
        {
            Console.WriteLine("\n--- DOCTOR MENU ---");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Update Doctor");
            Console.WriteLine("3. Delete Doctor");
            Console.WriteLine("4. View All Doctors");
            Console.WriteLine("5. Update Doctor Specialty");
            Console.WriteLine("6. View Doctors by Specialty");
            Console.WriteLine("7. Deactivate Doctor");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Name: "); string name = Console.ReadLine();
                    Console.Write("Contact: "); string contact = Console.ReadLine();
                    Console.Write("Consultation Fee: "); decimal fee = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Specialist ID: "); int specialist = Convert.ToInt32(Console.ReadLine());
                    doctorUtility.AddDoctor(name, contact, fee, specialist);
                    break;

                case 2:
                    Console.Write("Doctor ID: "); int did = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: "); string dname = Console.ReadLine();
                    Console.Write("Contact: "); string dcontact = Console.ReadLine();
                    Console.Write("Fee: "); decimal dfee = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Specialist ID: "); int dspecialist = Convert.ToInt32(Console.ReadLine());
                    doctorUtility.UpdateDoctor(did, dname, dcontact, dfee, dspecialist);
                    break;

                case 3:
                    Console.Write("Doctor ID: "); int deleteId = Convert.ToInt32(Console.ReadLine());
                    doctorUtility.DeleteDoctor(deleteId);
                    break;

                case 4:
                    doctorUtility.GetAllDoctors();
                    break;

                case 5:
                    Console.Write("Doctor ID: "); int updateId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("New Specialist ID: "); int newSpecialist = Convert.ToInt32(Console.ReadLine());
                    doctorUtility.UpdateDoctorSpecialty(updateId, newSpecialist);
                    break;

                case 6:
                    Console.Write("Specialty ID: "); int specialtyId = Convert.ToInt32(Console.ReadLine());
                    doctorUtility.GetDoctorsBySpecialty(specialtyId);
                    break;

                case 7:
                    Console.Write("Doctor ID: "); int deactivateId = Convert.ToInt32(Console.ReadLine());
                    doctorUtility.DeactivateDoctor(deactivateId);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter correct data types.");
        }
        catch (ClinicException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }

    private void AppointmentMenu()
    {
        try
        {
            Console.WriteLine("\n--- APPOINTMENT MENU ---");
            Console.WriteLine("1. Book Appointment");
            Console.WriteLine("2. Check Doctor Availability");
            Console.WriteLine("3. Cancel Appointment");
            Console.WriteLine("4. Reschedule Appointment");
            Console.WriteLine("5. View Daily Schedule");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Patient ID: "); int patientId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Doctor ID: "); int doctorId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Date (yyyy-MM-dd): "); DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Time: "); string time = Console.ReadLine();
                    appointmentUtility.BookAppointment(patientId, doctorId, date, time);
                    break;

                case 2:
                    Console.Write("Doctor ID: "); int did = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Date (yyyy-MM-dd): "); DateTime adate = DateTime.Parse(Console.ReadLine());
                    appointmentUtility.CheckDoctorAvailability(did, adate);
                    break;

                case 3:
                    Console.Write("Appointment ID: "); int cancelId = Convert.ToInt32(Console.ReadLine());
                    appointmentUtility.CancelAppointment(cancelId);
                    break;

                case 4:
                    Console.Write("Appointment ID: "); int aid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Doctor ID: "); int newDoc = Convert.ToInt32(Console.ReadLine());
                    Console.Write("New Date (yyyy-MM-dd): "); DateTime newDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("New Time: "); string newTime = Console.ReadLine();
                    appointmentUtility.RescheduleAppointment(aid, newDoc, newDate, newTime);
                    break;

                case 5:
                    Console.Write("Date (yyyy-MM-dd): "); DateTime viewDate = DateTime.Parse(Console.ReadLine());
                    appointmentUtility.ViewDailyAppointments(viewDate);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter correct data types.");
        }
        catch (ClinicException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }

    private void VisitMenu()
    {
        try
        {
            Console.WriteLine("\n--- VISIT & MEDICAL RECORDS ---");
            Console.WriteLine("1. Record Patient Visit");
            Console.WriteLine("2. View Patient Medical History");
            Console.WriteLine("3. Add Prescription");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Appointment ID: "); int appId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Diagnosis: "); string diagnosis = Console.ReadLine();
                    Console.Write("Notes: "); string notes = Console.ReadLine();
                    visitUtility.RecordPatientVisit(appId, diagnosis, notes);
                    break;

                case 2:
                    Console.Write("Patient ID: "); int patientId = Convert.ToInt32(Console.ReadLine());
                    visitUtility.ViewPatientMedicalHistory(patientId);
                    break;

                case 3:
                    Console.Write("Visit ID: "); int visitId = Convert.ToInt32(Console.ReadLine());

                    List<(string medicine, string dosage, string duration)> prescriptions = new List<(string, string, string)>();
                    Console.Write("How many medicines? "); int count = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("Medicine Name: "); string med = Console.ReadLine();
                        Console.Write("Dosage: "); string dosage = Console.ReadLine();
                        Console.Write("Duration: "); string duration = Console.ReadLine();

                        prescriptions.Add((med, dosage, duration));
                    }

                    visitUtility.AddPrescription(visitId, prescriptions);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter correct data types.");
        }
        catch (ClinicException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }

    private void BillingMenu()
    {
        try
        {
            Console.WriteLine("\n--- BILLING MENU ---");
            Console.WriteLine("1. Generate Bill");
            Console.WriteLine("2. Record Payment");
            Console.WriteLine("3. View Outstanding Bills");
            Console.WriteLine("4. Revenue Report");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Visit ID: "); int visitId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Additional Charges: "); decimal charges = Convert.ToDecimal(Console.ReadLine());
                    billingUtility.GenerateBill(visitId, charges);
                    break;

                case 2:
                    Console.Write("Bill ID: "); int billId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Payment Mode (Cash/Card/UPI): "); string mode = Console.ReadLine();
                    billingUtility.RecordPayment(billId, mode);
                    break;

                case 3:
                    billingUtility.ViewOutstandingBills();
                    break;

                case 4:
                    Console.Write("Start Date (yyyy-MM-dd): "); DateTime start = DateTime.Parse(Console.ReadLine());
                    Console.Write("End Date (yyyy-MM-dd): "); DateTime end = DateTime.Parse(Console.ReadLine());
                    billingUtility.GenerateRevenueReport(start, end);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter correct data types.");
        }
        catch (ClinicException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }

    private void AdminMenu()
    {
        try
        {
            Console.WriteLine("\n--- SYSTEM ADMINISTRATION ---");
            Console.WriteLine("1. Add Specialty");
            Console.WriteLine("2. Update Specialty");
            Console.WriteLine("3. Delete Specialty");
            Console.WriteLine("4. View Specialties");
            Console.WriteLine("5. View Audit Logs");
            Console.WriteLine("6. Back to Main Menu");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Specialty Name: "); string name = Console.ReadLine();
                    adminUtility.AddSpecialty(name);
                    break;

                case 2:
                    Console.Write("Specialty ID: "); int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("New Specialty Name: "); string newName = Console.ReadLine();
                    adminUtility.UpdateSpecialty(id, newName);
                    break;

                case 3:
                    Console.Write("Specialty ID: "); int deleteId = Convert.ToInt32(Console.ReadLine());
                    adminUtility.DeleteSpecialty(deleteId);
                    break;

                case 4:
                    adminUtility.ViewSpecialties();
                    break;

                case 5:
                    Console.Write("Filter by User (leave blank for all): "); string user = Console.ReadLine();
                    Console.Write("Filter by Table Name (leave blank for all): "); string table = Console.ReadLine();
                    Console.Write("From Date (yyyy-MM-dd) or press Enter: "); string fromInput = Console.ReadLine();
                    DateTime? from = string.IsNullOrEmpty(fromInput) ? null : DateTime.Parse(fromInput);
                    Console.Write("To Date (yyyy-MM-dd) or press Enter: "); string toInput = Console.ReadLine();
                    DateTime? to = string.IsNullOrEmpty(toInput) ? null : DateTime.Parse(toInput);

                    adminUtility.ViewAuditLogs(user, table, from, to);
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter correct data types.");
        }
        catch (ClinicException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}
