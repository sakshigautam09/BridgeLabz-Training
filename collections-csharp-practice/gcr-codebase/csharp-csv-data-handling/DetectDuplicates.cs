using System;
using System.IO;
using System.Collections.Generic;

class CSVDuplicateDetector
{
    private string filePath;

    public CSVDuplicateDetector(string filePath)
    {
        this.filePath = filePath;
    }

    public void DetectDuplicates()
    {
        HashSet<int> seenIds = new HashSet<int>();
        bool hasDuplicates = false;

        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] data = line.Split(',');
                    int id = Convert.ToInt32(data[0]);

                    if (!seenIds.Add(id))
                    {
                        Console.WriteLine("Duplicate Record Found:");
                        Console.WriteLine(line);
                        Console.WriteLine("-----------------------");
                        hasDuplicates = true;
                    }
                }
            }

            if (!hasDuplicates)
            {
                Console.WriteLine("No duplicate records found.");
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading CSV file.");
        }
    }
}

class DetectDuplicates
{
    static void Main()
    {
        CSVDuplicateDetector detector =
            new CSVDuplicateDetector("employees.csv");

        detector.DetectDuplicates();
    }
}
