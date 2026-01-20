using System.Collections.Generic;

public class Resume<T> where T : JobRole
{
    private readonly List<T> jobRoles = new List<T>();

    public void AddRole(T role)
    {
        jobRoles.Add(role);
    }

    public void Screen()
    {
        foreach (var role in jobRoles)
        {
            System.Console.WriteLine($"Screening resume for {role.RoleName}");
        }
    }
}
