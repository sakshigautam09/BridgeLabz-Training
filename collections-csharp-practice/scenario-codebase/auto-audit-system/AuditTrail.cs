using System;

[AttributeUsage(AttributeTargets.Method)]
public class AuditTrail : Attribute
{
    // Optional: you can add metadata here if needed, e.g., action type
    public string Action { get; }

    public AuditTrail(string action = "")
    {
        Action = action;
    }
}
