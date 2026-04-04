public class TimberTransport : GoodsTransport
{
    private float length;
    private float radius;
    private string timberType;
    private float timberPrice;

    public TimberTransport(string id, string date, int rating, float length, float radius, string type, 
                float price) : base(id, date, rating)
    {
        this.length = length;
        this.radius = radius;
        timberType = type;
        timberPrice = price;
    }

    public string TimberType { get { return timberType; } }
    public float TimberPrice { get { return timberPrice; } }

    public override string vehicleSelection()
    {
        float area = 2 * 3.147f * radius * length;

        if (area < 250) return "Truck";
        if (area <= 400) return "Lorry";
        return "MonsterLorry";
    }

    public override float calculateTotalCharge()
    {
        float volume = 3.147f * radius * radius * length;
        float rate = timberType.Equals("Premium") ? 0.25f : 0.15f;

        float price = volume * timberPrice * rate;
        float tax = price * 0.3f;

        float discount = 0;
        if (transportRating == 5) discount = price * 0.2f;
        else if (transportRating >= 3) discount = price * 0.1f;

        float vehicleCost = vehicleSelection() == "Truck" ? 1000 : vehicleSelection() == "Lorry" ? 1700 : 3000;

        return price + tax + vehicleCost - discount;
    }
}
