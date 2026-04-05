using System;
using System.Collections.Generic;

public interface IVisitService
{
    void RecordPatientVisit(int appointmentId, string diagnosis, string notes);
    void ViewPatientMedicalHistory(int patientId);
    void AddPrescription(int visitId, List<(string medicine, string dosage, string duration)> prescriptions);
}