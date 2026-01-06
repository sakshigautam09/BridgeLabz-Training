public class Penguin : Bird, ISwimmable
{
    public Penguin(string name)
        : base(name, "Penguin") { }

    public void Swim()
    {
        Console.WriteLine($"{name} swims swiftly underwater.");
    }
}
