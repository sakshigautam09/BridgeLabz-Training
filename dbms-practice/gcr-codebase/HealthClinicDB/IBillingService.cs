using System;

public interface IBillingService
{
    void GenerateBill(int visitId, decimal additionalCharges);
    void RecordPayment(int billId, string paymentMode);
    void ViewOutstandingBills();
    void GenerateRevenueReport(DateTime startDate, DateTime endDate);
}
