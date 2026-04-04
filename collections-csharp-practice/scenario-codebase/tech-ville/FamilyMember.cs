// ================= UC-2 =================
// Multiple family member model
// ========================================

public class FamilyMember
{
    public string Name;
    public int Age;
    public double Income;
    public int ResidencyYears;
    public string Package;

    public FamilyMember()
    {
    }
    // ================= UC-2 ADDITION =================
    public FamilyMember(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // ================= UC-2 ADDITION =================
    public FamilyMember(string name, int age, double income, int residencyYears)
    {
        Name = name;
        Age = age;
        Income = income;
        ResidencyYears = residencyYears;
    }

    // ================= UC-4 =================

    public void UpdateIncome(double income)
    {
        Income = income;
    }

    public void UpdateResidency(int years)
    {
        ResidencyYears = years;
    }

    public void AssignPackage(string packageName)
    {
        Package = packageName;
    }
}
