public sealed class Bill
{
    private IPayable payable;

    public Bill(IPayable payable)
    {
        this.payable = payable;
    }

    public void PrintBill()
    {
        Console.WriteLine($"Final Amount to Pay: {payable.CalculateBill()}");
    }
}
