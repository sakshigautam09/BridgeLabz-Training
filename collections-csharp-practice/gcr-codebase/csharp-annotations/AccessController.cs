using System;
using System.Reflection;

// --------------------- RoleAllowed Attribute ---------------------
[AttributeUsage(AttributeTargets.Method)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; set; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

// --------------------- Service Class ---------------------
public class AdminService
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted successfully.");
    }

    [RoleAllowed("ADMIN")]
    public void ViewAllUsers()
    {
        Console.WriteLine("Displaying all users.");
    }

    public void ViewProfile()
    {
        Console.WriteLine("Viewing profile.");
    }
}

// --------------------- Access Controller ---------------------
public class AccessController
{
    public static void ExecuteMethod(object obj, string methodName, string currentUserRole)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Method not found.");
            return;
        }

        object[] attributes =
            method.GetCustomAttributes(typeof(RoleAllowedAttribute), false);

        if (attributes.Length > 0)
        {
            RoleAllowedAttribute roleAttr =
                (RoleAllowedAttribute)attributes[0];

            if (roleAttr.Role != currentUserRole)
            {
                Console.WriteLine("Access Denied!");
                return;
            }
        }

        method.Invoke(obj, null);
    }
}

// --------------------- Main Program ---------------------
public class AccessController
{
    public static void Main()
    {
        AdminService service = new AdminService();

        string currentUserRole = "USER";   // Try changing to "ADMIN"

        Console.WriteLine("Current Role: " + currentUserRole);
        Console.WriteLine();

        AccessController.ExecuteMethod(service, "DeleteUser", currentUserRole);
        AccessController.ExecuteMethod(service, "ViewAllUsers", currentUserRole);
        AccessController.ExecuteMethod(service, "ViewProfile", currentUserRole);
    }
}
