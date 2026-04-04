using System;

// --------------------- LegacyAPI Class ---------------------
public class LegacyAPI
{
    // Old method marked as obsolete
    [Obsolete("OldFeature is deprecated. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Executing old feature...");
    }

    // New recommended method
    public void NewFeature()
    {
        Console.WriteLine("Executing new feature...");
    }
}

// --------------------- Example Usage ---------------------
public class ObseleteAttributes
{
    public static void Main()
    {
        LegacyAPI api = new LegacyAPI();

        // Calling old method (will show compiler warning)
        api.OldFeature();  

        // Calling new method (recommended)
        api.NewFeature();
    }
}
