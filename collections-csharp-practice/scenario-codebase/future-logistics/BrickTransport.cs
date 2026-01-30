public class BrickTransport : GoodsTransport
{
    private int brickQuantity;
    private float brickPrice;

    public BrickTransport(string id, string date, int rating, int quantity, float price) : base(id, date, rating)
    {
        brickQuantity = quantity;
        brickPrice = price;
    }

    public int BrickQuantity { get { return brickQuantity; } }
    public float BrickPrice { get { return brickPrice; } }

    public override string vehicleSelection()
    {
        if (brickQuantity < 300) return "Truck";
        if (brickQuantity <= 500) return "Lorry";
        return "MonsterLorry";
    }

    public override float calculateTotalCharge()
    {
        float price = brickQuantity * brickPrice;
        float tax = price * 0.3f;

        float discount = 0;
        if (transportRating == 5) discount = price * 0.2f;
        else if (transportRating >= 3) discount = price * 0.1f;

        float vehicleCost = vehicleSelection() == "Truck" ? 1000 : vehicleSelection() == "Lorry" ? 1700 : 3000;

        return price + tax + vehicleCost - discount;
    }
}
