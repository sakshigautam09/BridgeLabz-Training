using System;

public interface IDoctorService
{
    void AddDoctor(string name, string contact, decimal fee, int specialistId);
    void UpdateDoctor(int id, string name, string contact, decimal fee, int specialistId);
    void DeleteDoctor(int id);
    void GetAllDoctors();
    void UpdateDoctorSpecialty(int id, int specialistId);
    void GetDoctorsBySpecialty(int specialtyId);
    void DeactivateDoctor(int id);
}
