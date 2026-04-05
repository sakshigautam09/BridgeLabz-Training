using Microsoft.Data.SqlClient;
using System;

public class DoctorUtility : IDoctorService
{
    public void AddDoctor(string name, string contact, decimal fee, int specialistId)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_doctor", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@specialist", specialistId);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " doctor(s) added.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while adding doctor: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while adding doctor: " + ex.Message);
        }
    }

    public void UpdateDoctor(int id, string name, string contact, decimal fee, int specialistId)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_update_doctor", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@specialist", specialistId);
                cmd.Parameters.AddWithValue("@is_active", true); // REQUIRED

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " doctor(s) updated.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while updating doctor: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while updating doctor: " + ex.Message);
        }
    }

    public void DeleteDoctor(int id)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_doctor", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " doctor(s) deleted.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while deleting doctor: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while deleting doctor: " + ex.Message);
        }
    }

    public void GetAllDoctors()
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_get_all_doctors", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("ID | Name | Contact | Fee | SpecialistID | IsActive");
                    Console.WriteLine("---------------------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"{reader["doctor_id"]} | {reader["doctor_name"]} | {reader["contact"]} | {reader["consultation_fee"]} | {reader["specialist_id"]} | {reader["is_active"]}"
                        );
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while retrieving all doctors: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while retrieving all doctors: " + ex.Message);
        }
    }

    public void UpdateDoctorSpecialty(int id, int specialistId)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_update_doctor_specialty", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@specialist", specialistId);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " doctor(s) specialty updated.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while updating doctor specialty: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while updating doctor specialty: " + ex.Message);
        }
    }


    public void GetDoctorsBySpecialty(int specialtyId)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_get_doctors_by_specialty", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@specialty_id", specialtyId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("ID | Name | Contact | Fee | SpecialistID | IsActive");
                    Console.WriteLine("---------------------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"{reader["doctor_id"]} | {reader["doctor_name"]} | {reader["contact"]} | {reader["consultation_fee"]} | {reader["specialist_id"]} | {reader["is_active"]}"
                        );
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while retrieving doctors by specialty: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while retrieving doctors by specialty: " + ex.Message);
        }
    }


    public void DeactivateDoctor(int id)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_deactivate_doctor", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " doctor(s) deactivated.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while deactivating doctor: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while deactivating doctor: " + ex.Message);
        }
    }
}
