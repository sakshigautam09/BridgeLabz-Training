using Microsoft.Data.SqlClient;
using System;

public class AppointmentUtility : IAppointmentService
{
    public void BookAppointment(int patientId, int doctorId, DateTime appointmentDate, string appointmentTime)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_book_appointment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Convert string to TimeSpan
                TimeSpan time = TimeSpan.Parse(appointmentTime);

                cmd.Parameters.AddWithValue("@patient_id", patientId);
                cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                cmd.Parameters.AddWithValue("@appointment_date", appointmentDate);
                cmd.Parameters.AddWithValue("@appointment_time", time);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " appointment(s) booked.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while booking appointment: " + ex.Message);
        }
        catch (FormatException ex)
        {
            throw new ClinicException("Invalid time format. Please use HH:mm. " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while booking appointment: " + ex.Message);
        }
    }

    public void CheckDoctorAvailability(int doctorId, DateTime appointmentDate)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_check_doctor_availability", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                    cmd.Parameters.AddWithValue("@appointment_date", appointmentDate);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\nTime Slot | Booked Count");
                        Console.WriteLine("--------------------------");

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                $"{reader["appointment_time"]} | {reader["booked_slots"]}"
                            );
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while checking doctor availability: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error: " + ex.Message);
        }
    }

    public void CancelAppointment(int appointmentId)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_cancel_appointment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@appointment_id", appointmentId);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " appointment(s) cancelled.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while cancelling appointment: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while cancelling appointment: " + ex.Message);
        }
    }

    public void RescheduleAppointment(int appointmentId, int doctorId, DateTime newDate, string newTime)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("dbo.sp_reschedule_appointment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                TimeSpan time = TimeSpan.Parse(newTime);

                cmd.Parameters.AddWithValue("@appointment_id", appointmentId);
                cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                cmd.Parameters.AddWithValue("@new_date", newDate);
                cmd.Parameters.AddWithValue("@new_time", time);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " appointment(s) rescheduled.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while rescheduling appointment: " + ex.Message);
        }
        catch (FormatException)
        {
            throw new ClinicException("Invalid time format. Use HH:mm (example: 16:00).");
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while rescheduling appointment: " + ex.Message);
        }
    }


    public void ViewDailyAppointments(DateTime date)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("dbo.sp_view_daily_appointments", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@appointment_date", date);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("AppointmentID | PatientName | DoctorName | Time | Status");
                    Console.WriteLine("----------------------------------------------------------");

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"{reader["appointment_id"]} | {reader["patient_name"]} | {reader["doctor_name"]} | " +
                            $"{reader["appointment_time"]} | {reader["status"]}"
                        );
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while viewing daily appointments: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while viewing daily appointments: " + ex.Message);
        }
    }
}
