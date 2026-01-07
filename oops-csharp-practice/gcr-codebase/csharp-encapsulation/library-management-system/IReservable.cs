public interface IReservable
{
    void ReserveItem(string borrowerName);
    bool CheckAvailability();
}
