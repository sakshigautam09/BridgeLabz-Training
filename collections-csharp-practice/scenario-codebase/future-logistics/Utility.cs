public class Utility
{
    public bool validateTransportId(string id)
    {
        if (id.Length != 7 || !id.StartsWith("RTS") ||
            !char.IsDigit(id[3]) || !char.IsDigit(id[4]) ||
            !char.IsDigit(id[5]) || !char.IsUpper(id[6]))
        {
            Console.WriteLine("Transport id " + id + " is invalid");
            Console.WriteLine("Please provide a valid record");
            return false;
        }
        return true;
    }

    public GoodsTransport parseDetails(string input)
    {
        string[] d = input.Split(':');

        if (d[3].Equals("BrickTransport"))
            return new BrickTransport(d[0], d[1], int.Parse(d[2]), int.Parse(d[5]), float.Parse(d[6]));

        return new TimberTransport(d[0], d[1], int.Parse(d[2]), float.Parse(d[4]), float.Parse(d[5]), 
            d[6], float.Parse(d[7]));
    }
}
