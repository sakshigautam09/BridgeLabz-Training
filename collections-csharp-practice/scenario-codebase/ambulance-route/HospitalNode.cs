class HospitalNode
{
    public string unitName;
    public bool isAvailable;
    public HospitalNode next;

    public HospitalNode(string name, bool available)
    {
        unitName = name;
        isAvailable = available;
        next = null;
    }
}
