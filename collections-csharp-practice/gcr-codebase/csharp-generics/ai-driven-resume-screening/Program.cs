class Program
{
    static void Main()
    {
        Resume<SoftwareEngineer> seResume = new Resume<SoftwareEngineer>();
        seResume.AddRole(new SoftwareEngineer());
        seResume.Screen();

        Resume<DataScientist> dsResume = new Resume<DataScientist>();
        dsResume.AddRole(new DataScientist());
        dsResume.Screen();
    }
}
