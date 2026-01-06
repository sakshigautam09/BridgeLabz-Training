public class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name)
        : base(name, "Seagull") { }

    public void Fly()
    {
        Console.WriteLine($"{name} flies over the ocean.");
    }

    public void Swim()
    {
        Console.WriteLine($"{name} floats on sea water.");
    }
}
