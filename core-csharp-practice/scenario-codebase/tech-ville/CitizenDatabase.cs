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

    // Add citizen ID
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

    // Update zone-sector data
    public void UpdateZoneSector(int zone, int sector)
    {
        zoneSectorCounts[zone, sector]++;
    }

    // Display IDs
    public void DisplayCitizenIds()
    {
        Console.WriteLine("\nCitizen IDs:");
        foreach (int id in citizenIds)
        {
            Console.Write(id + " ");
        }
    }

    // Display 2D array
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
}
