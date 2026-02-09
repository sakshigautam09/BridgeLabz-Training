using Microsoft.Data.SqlClient;
using System;

public class BillingUtility : IBillingService
{
    public void GenerateBill(int visitId, decimal additionalCharges)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_generate_bill", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@visit_id", visitId);
                cmd.Parameters.AddWithValue("@additional_charges", additionalCharges);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " bill generated.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while generating bill: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while generating bill: " + ex.Message);
        }
    }

    public void RecordPayment(int billId, string paymentMode)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_record_payment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@bill_id", billId);
                cmd.Parameters.AddWithValue("@payment_mode", paymentMode);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " payment recorded.");
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while recording payment: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while recording payment: " + ex.Message);
        }
    }

    public void ViewOutstandingBills()
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_view_outstanding_bills", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("Patient | Total Unpaid Bills | Total Amount");
                    Console.WriteLine("-------------------------------------------");

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["patient_name"]} | {reader["total_bills"]} | {reader["total_amount"]}");
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while viewing outstanding bills: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while viewing outstanding bills: " + ex.Message);
        }
    }

    public void GenerateRevenueReport(DateTime startDate, DateTime endDate)
    {
        try
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_generate_revenue_report", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@start_date", startDate);
                cmd.Parameters.AddWithValue("@end_date", endDate);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("Doctor | Total Revenue");
                    Console.WriteLine("-----------------------");

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["doctor_name"]} | {reader["revenue"]}");
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new ClinicException("Database error while generating revenue report: " + ex.Message);
        }
        catch (Exception ex)
        {
            throw new ClinicException("Unexpected error while generating revenue report: " + ex.Message);
        }
    }
}
