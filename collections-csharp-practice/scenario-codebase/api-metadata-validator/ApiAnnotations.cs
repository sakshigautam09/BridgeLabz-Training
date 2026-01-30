using System;

[AttributeUsage(AttributeTargets.Method)]
public class PublicAPI : Attribute
{
}

[AttributeUsage(AttributeTargets.Method)]
public class RequiresAuth : Attribute
{
}
