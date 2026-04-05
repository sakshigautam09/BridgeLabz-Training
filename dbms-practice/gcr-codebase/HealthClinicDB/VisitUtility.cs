using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

public class VisitUtility : IVisitService
{
    // UC-4.1 Record Patient Visit
    public void RecordPatientVisit(int appointmentId, string diagnosis, string notes)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_record_visit", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@appointment_id", appointmentId);
                cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                cmd.Parameters.AddWithValue("@notes", notes);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " visit record inserted.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while recording patient visit: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while recording patient visit: " + ex.Message);
        }
    }


    // UC-4.2 View Patient Medical History
    public void ViewPatientMedicalHistory(int patientId)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_view_patient_medical_history", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@patient_id", patientId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("VisitID | Diagnosis | Medicine | Dosage | Duration | Visit Date");
                    Console.WriteLine("----------------------------------------------------------------");

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"{reader["visit_id"]} | {reader["diagnosis"]} | {reader["medicine_name"]} | " +
                            $"{reader["dosage"]} | {reader["duration"]} | {Convert.ToDateTime(reader["visit_date"]).ToString("yyyy-MM-dd")}"
                        );
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while viewing patient medical history: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while viewing patient medical history: " + ex.Message);
        }
    }

    // UC-4.3 Add Prescription (Batch Insert)
    public void AddPrescription(int visitId, List<(string medicine, string dosage, string duration)> prescriptions)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                foreach (var item in prescriptions)
                {
                    SqlCommand cmd = new SqlCommand("sp_add_prescription", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@visit_id", visitId);
                    cmd.Parameters.AddWithValue("@medicine_name", item.medicine);
                    cmd.Parameters.AddWithValue("@dosage", item.dosage);
                    cmd.Parameters.AddWithValue("@duration", item.duration);

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Prescription records added successfully.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while adding prescriptions: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while adding prescriptions: " + ex.Message);
        }
    }
}
