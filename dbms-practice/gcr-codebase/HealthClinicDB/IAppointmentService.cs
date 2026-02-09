using System;

public interface IAppointmentService
{
    void BookAppointment(int patientId, int doctorId, DateTime appointmentDate, string appointmentTime);
    void CheckDoctorAvailability(int doctorId, DateTime date);
    void CancelAppointment(int appointmentId);
    void RescheduleAppointment(int appointmentId, int doctorId, DateTime newDate, string newTime);
    void ViewDailyAppointments(DateTime date);
}
