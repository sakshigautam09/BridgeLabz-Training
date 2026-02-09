using System;

public interface IPatientService
{
    void AddPatient(string name, DateTime dob, string phone, string email, string address, string bloodGroup, int doctorId);
    void UpdatePatient(int id, string name, DateTime dob, string phone, string email, string address, string bloodGroup, int doctorId);
    void DeletePatient(int id);
    void GetAllPatients();
    void SearchPatient(string search);
    void GetPatientVisitHistory(int patientId);
}
