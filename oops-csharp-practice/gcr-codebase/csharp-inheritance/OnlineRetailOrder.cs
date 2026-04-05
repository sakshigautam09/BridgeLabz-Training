using System;
class Order
{
    public int OrderId;
    public DateTime OrderDate;

    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber;

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
}

class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate;

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }
}

class OnlineRetailOrder
{
    static void Main()
    {
        Order o1 = new Order(1, DateTime.Now);
        Order o2 = new ShippedOrder(2, DateTime.Now, "TRACK123");
        Order o3 = new DeliveredOrder(3, DateTime.Now, "TRACK456", DateTime.Now);

        Console.WriteLine(o1.GetOrderStatus());
        Console.WriteLine(o2.GetOrderStatus());
        Console.WriteLine(o3.GetOrderStatus());
    }
}
