using Microsoft.Data.SqlClient;
using System;

public class PatientUtility : IPatientService
{
    public void AddPatient(string name, DateTime dob, string phone, string email, string address, string bloodGroup, int doctorId)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_patient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@blood", bloodGroup);
                cmd.Parameters.AddWithValue("@doctor_id", doctorId);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " patient(s) added.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while adding patient: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while adding patient: " + ex.Message);
        }
    }

    public void UpdatePatient(int id, string name, DateTime dob, string phone, string email, string address, string bloodGroup, int doctorId)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_update_patient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@blood", bloodGroup);
                cmd.Parameters.AddWithValue("@doctor_id", doctorId);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " patient(s) updated.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while updating patient: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while updating patient: " + ex.Message);
        }
    }

    public void DeletePatient(int id)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_patient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " patient(s) deleted.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while deleting patient: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while deleting patient: " + ex.Message);
        }
    }

    public void GetAllPatients()
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_get_all_patients", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("ID | Name | DOB | Phone | Email | Address | Blood | DoctorID");
                    Console.WriteLine("------------------------------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"{reader["patient_id"]} | {reader["patient_name"]} | {Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd")} | {reader["phone"]} | {reader["email"]} | {reader["address"]} | {reader["blood_group"]} | {reader["doctor_id"]}"
                        );
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while retrieving all patients: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while retrieving all patients: " + ex.Message);
        }
    }

    public void SearchPatient(string search)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_search_patient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@search", search);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("ID | Name | DOB | Phone | Email | Address | Blood | DoctorID");
                    Console.WriteLine("------------------------------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"{reader["patient_id"]} | {reader["patient_name"]} | {Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd")} | {reader["phone"]} | {reader["email"]} | {reader["address"]} | {reader["blood_group"]} | {reader["doctor_id"]}"
                        );
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while searching patients: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while searching patients: " + ex.Message);
        }
    }

    public void GetPatientVisitHistory(int patientId)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_get_patient_visithistory", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@patient_id", patientId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("VisitID | Diagnosis | Notes | VisitDate | DoctorName");
                    Console.WriteLine("---------------------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"{reader["visit_id"]} | {reader["diagnosis"]} | {reader["notes"]} | {Convert.ToDateTime(reader["visit_date"]).ToString("yyyy-MM-dd")} | {reader["doctor_name"]}"
                        );
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while retrieving patient visit history: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while retrieving patient visit history: " + ex.Message);
        }
    }
}
