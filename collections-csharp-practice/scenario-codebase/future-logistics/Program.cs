using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the Goods Transport details");
        string input = Console.ReadLine();

        Utility util = new Utility();
        GoodsTransport gt = util.parseDetails(input);

        if (!util.validateTransportId(gt.TransportId))
            return;

        Console.WriteLine("\nTransporter id : " + gt.TransportId);
        Console.WriteLine("Date of transport : " + gt.TransportDate);
        Console.WriteLine("Rating of the transport : " + gt.TransportRating);

        if (gt is BrickTransport)
        {
            BrickTransport b = (BrickTransport)gt;
            Console.WriteLine("Quantity of bricks : " + b.BrickQuantity);
            Console.WriteLine("Brick price : " + b.BrickPrice);
        }
        else
        {
            TimberTransport t = (TimberTransport)gt;
            Console.WriteLine("Type of the timber : " + t.TimberType);
            Console.WriteLine("Timber price per kilo : " + t.TimberPrice);
        }

        Console.WriteLine("Vehicle for transport : " + gt.vehicleSelection());
        Console.WriteLine("Total charge : " + gt.calculateTotalCharge());
    }
}
