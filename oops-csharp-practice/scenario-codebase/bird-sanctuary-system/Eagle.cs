public class Eagle : Bird, IFlyable
{
    public Eagle(string name)
        : base(name, "Eagle") { }

    public void Fly()
    {
        Console.WriteLine($"{name} soars high in the sky.");
    }
}
