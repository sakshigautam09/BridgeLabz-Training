using Microsoft.Data.SqlClient;
using System;

public class AdminUtility : IAdminService
{
    public void AddSpecialty(string specialtyName)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_add_specialty", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@specialty_name", specialtyName);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " specialty added.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while adding specialty: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while adding specialty: " + ex.Message);
        }
    }

    public void UpdateSpecialty(int id, string specialtyName)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_update_specialty", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@specialty_name", specialtyName);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " specialty updated.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while updating specialty: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while updating specialty: " + ex.Message);
        }
    }

    public void DeleteSpecialty(int id)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_specialty", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " specialty deleted.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while deleting specialty: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while deleting specialty: " + ex.Message);
        }
    }

    public void ViewSpecialties()
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_view_specialties", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("ID | Specialty Name");
                    Console.WriteLine("--------------------");

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["specialty_id"]} | {reader["specialty_name"]}");
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while viewing specialties: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while viewing specialties: " + ex.Message);
        }
    }

    public void TriggerDatabaseBackup()
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_trigger_database_backup", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                Console.WriteLine("Database backup triggered successfully.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while triggering backup: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while triggering backup: " + ex.Message);
        }
    }

    public void ViewAuditLogs(string user, string tableName, DateTime? from, DateTime? to)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_view_audit_logs", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user", (object)user ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@table", (object)tableName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@from", (object)from ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@to", (object)to ?? DBNull.Value);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("LogID | User | Table | Action | Timestamp");
                    Console.WriteLine("------------------------------------------");

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"{reader["log_id"]} | {reader["user_name"]} | {reader["table_name"]} | " +
                            $"{reader["action"]} | {reader["timestamp"]}"
                        );
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while viewing audit logs: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while viewing audit logs: " + ex.Message);
        }
    }
}
