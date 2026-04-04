public abstract class GoodsTransport
{
    protected string transportId;
    protected string transportDate;
    protected int transportRating;

    public GoodsTransport(string id, string date, int rating)
    {
        transportId = id;
        transportDate = date;
        transportRating = rating;
    }

    public string TransportId { get { return transportId; } }
    public string TransportDate { get { return transportDate; } }
    public int TransportRating { get { return transportRating; } }

    public abstract string vehicleSelection();
    public abstract float calculateTotalCharge();
}
