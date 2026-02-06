abstract class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        this.Name = name;
    }
    public abstract void Menu(TicketService service);
}
