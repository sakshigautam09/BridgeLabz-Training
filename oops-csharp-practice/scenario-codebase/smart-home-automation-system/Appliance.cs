public abstract class Appliance : IControllable
{
    private string name;   // Encapsulation

    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }

    protected Appliance(string name)
    {
        this.name = name;   
    }

    public abstract void TurnOn();   
    public abstract void TurnOff();
}
