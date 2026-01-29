using System;
using System.IO;

class CSVRowCounter
{
    private string filePath;

    // Constructor
    public CSVRowCounter(string filePath)
    {
        this.filePath = filePath;
    }

    public int CountRecords()
    {
        int count = 0;

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                // Exclude header row
                count = lines.Length - 1;
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error: Unable to read the CSV file.");
        }

        return count;
    }
}

class CountRows
{
    static void Main()
    {
        CSVRowCounter counter = new CSVRowCounter("employees.csv");
        int totalRecords = counter.CountRecords();

        Console.WriteLine("Total Records (excluding header): " + totalRecords);
    }
}
