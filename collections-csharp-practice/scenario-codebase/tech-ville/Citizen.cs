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

    // UC-1 constructor
    public Citizen(int citizenId, string name, int age, double income, int residencyYears)
    {
        this.citizenId = citizenId;
        this.name = name;
        this.age = age;
        this.income = income;
        this.residencyYears = residencyYears;
    }

    // UC-1 getters (read-only properties)
    public int CitizenId { get { return citizenId; } }
    public string Name { get { return name; } }
    public int Age { get { return age; } }
    public double Income { get { return income; } }
    public int ResidencyYears { get { return residencyYears; } }


    // ================= UC-4 ADDITION =================
    // Future profile updates require setters
    // Only enable update features later

    public void UpdateName(string newName)
    {
        name = newName;
    }

    public void UpdateIncome(double newIncome)
    {
        income = newIncome;
    }

    public void UpdateResidencyYears(int years)
    {
        residencyYears = years;
    }
}
