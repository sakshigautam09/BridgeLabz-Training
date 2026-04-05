// ======================================
// UC-3: Smart Citizen Database
// 1D and 2D Arrays with user-driven data
// ======================================

using System;

public class CitizenDatabase
{
    private int[] citizenIds;
    private int[,] zoneSectorCounts;
    private int index = 0;

    public CitizenDatabase(int size)
    {
        citizenIds = new int[size];
        zoneSectorCounts = new int[5, 4]; // 5 zones, 4 sectors
    }

    public void AddCitizenId(int id)
    {
        if (index < citizenIds.Length)
        {
            citizenIds[index++] = id;
        }
        else
        {
            Console.WriteLine("Database full!");
        }
    }

    public int[] GetCitizenIds()
    {
        return citizenIds;
    }

    public void UpdateZoneSector(int zone, int sector)
    {
        zoneSectorCounts[zone, sector]++;
    }

    public void DisplayCitizenIds()
    {
        Console.WriteLine("\nCitizen IDs:");
        foreach (int id in citizenIds)
        {
            Console.Write(id + " ");
        }
    }

    public void DisplayZoneSectorData()
    {
        Console.WriteLine("\nZone-Sector Citizen Count:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(zoneSectorCounts[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // ================= UC-3 ADDITIONS================

    // Total citizens stored
    public int GetTotalCitizens()
    {
        return index;
    }

    // Validate zone-sector before update
    public bool IsValidZoneSector(int zone, int sector)
    {
        return zone >= 0 && zone < 5 && sector >= 0 && sector < 4;
    }

    // Safe update with validation
    public void SafeUpdateZoneSector(int zone, int sector)
    {
        if (IsValidZoneSector(zone, sector))
        {
            zoneSectorCounts[zone, sector]++;
        }
        else
        {
            Console.WriteLine("Invalid zone/sector entered.");
        }
    }

    // Search citizen ID in array
    public bool ContainsCitizenId(int id)
    {
        for (int i = 0; i < index; i++)
        {
            if (citizenIds[i] == id)
                return true;
        }
        return false;
    }

    // Copy array (manual operation)
    public int[] CopyCitizenIds()
    {
        int[] copy = new int[index];
        for (int i = 0; i < index; i++)
        {
            copy[i] = citizenIds[i];
        }
        return copy;
    }
}
