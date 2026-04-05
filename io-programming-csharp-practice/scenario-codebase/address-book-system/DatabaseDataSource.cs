using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


public class DatabaseDataSource : IDataSource
{
    private readonly string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=True;";

    public async Task SaveAsync(List<Contact> contacts, string bookName)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            await conn.OpenAsync();

            foreach (var c in contacts)
            {
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Contacts 
                    (FirstName, LastName, Address, City, State, Zip, Phone, Email, BookName)
                    VALUES (@fn,@ln,@addr,@city,@state,@zip,@phone,@email,@book)", conn);

                cmd.Parameters.AddWithValue("@fn", c.GetFirstName());
                cmd.Parameters.AddWithValue("@ln", c.GetLastName());
                cmd.Parameters.AddWithValue("@addr", c.GetAddress());
                cmd.Parameters.AddWithValue("@city", c.GetCity());
                cmd.Parameters.AddWithValue("@state", c.GetState());
                cmd.Parameters.AddWithValue("@zip", c.GetZip());
                cmd.Parameters.AddWithValue("@phone", c.GetPhoneNumber());
                cmd.Parameters.AddWithValue("@email", c.GetEmail());
                cmd.Parameters.AddWithValue("@book", bookName);

                await cmd.ExecuteNonQueryAsync();
            }
        }

        Console.WriteLine("Contacts saved to DATABASE successfully.");
    }

    public async Task<List<Contact>> LoadAsync(string bookName)
    {
        List<Contact> contacts = new List<Contact>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            await conn.OpenAsync();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Contacts WHERE BookName=@book", conn);

            cmd.Parameters.AddWithValue("@book", bookName);

            SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                contacts.Add(new Contact(
                    reader["FirstName"].ToString(),
                    reader["LastName"].ToString(),
                    reader["Address"].ToString(),
                    reader["City"].ToString(),
                    reader["State"].ToString(),
                    reader["Zip"].ToString(),
                    reader["Phone"].ToString(),
                    reader["Email"].ToString()
                ));
            }
        }

        Console.WriteLine("Contacts loaded from DATABASE successfully.");
        return contacts;
    }
}
