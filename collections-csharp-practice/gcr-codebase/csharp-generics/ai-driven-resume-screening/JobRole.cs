public abstract class JobRole
{
    public string RoleName { get; }

    protected JobRole(string roleName)
    {
        RoleName = roleName;
    }
}
