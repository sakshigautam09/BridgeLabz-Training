using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
public class AddressBookMetadataAttribute : Attribute
{
    public string Module { get; }
    public string Author { get; }
    public string Version { get; }

    public AddressBookMetadataAttribute(string module, string author, string version)
    {
        Module = module;
        Author = author;
        Version = version;
    }
}
