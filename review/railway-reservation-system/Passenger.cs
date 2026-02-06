public abstract class Passenger{
    public string Name { get; set; }
    public int PNR { get; set; }
    public int Age { get; set; }

    public abstract double CalculateFare();

    public virtual void Display()
    {
        Console.WriteLine($"PNR: {PNR}, Name: {Name}, Age: {Age}, Fare: Rs.{CalculateFare()}");
    }
}