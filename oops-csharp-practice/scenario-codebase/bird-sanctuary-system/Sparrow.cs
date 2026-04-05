public class Sparrow : Bird, IFlyable
{
    public Sparrow(string name)
        : base(name, "Sparrow") { }

    public void Fly()
    {
        Console.WriteLine($"{name} flies swiftly between trees.");
    }
}
