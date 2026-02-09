using Microsoft.Data.SqlClient;

class DBConnection
{
    private static string connectionString = 
        "Server=localhost\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=true;TrustServerCertificate=true;";

    public static SqlConnection GetConnection()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }
}
