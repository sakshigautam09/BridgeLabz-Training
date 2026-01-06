public abstract class Bird
{
    protected string name;
    protected string species;

    protected Bird(string name, string species)
    {
        this.name = name;
        this.species = species;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Species: {species}");
    }
}
