using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class UserAccessAttribute : Attribute
{
    public string[] AllowedRoles { get; }

    public UserAccessAttribute(params string[] allowedRoles)
    {
        AllowedRoles = allowedRoles;
    }
}