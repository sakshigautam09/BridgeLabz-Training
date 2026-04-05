public class Fan : Appliance
{
    public Fan(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine($"{Name} Fan is rotating at medium speed");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Name} Fan is stopped");
    }
}
