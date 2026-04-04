// ================= UC-1 =================
// Citizen Registration Portal
// Basic data holder
// ========================================

public class Citizen
{
    private int citizenId;
    private string name;
    private int age;
    private double income;
    private int residencyYears;

    public Citizen(int citizenId, string name, int age, double income, int residencyYears)
    {
        this.citizenId = citizenId;
        this.name = name;
        this.age = age;
        this.income = income;
        this.residencyYears = residencyYears;
    }

    public int CitizenId { get { return citizenId; } }
    public string Name { get { return name; } }
    public int Age { get { return age; } }
    public double Income { get { return income; } }
    public int ResidencyYears { get { return residencyYears; } }
}
