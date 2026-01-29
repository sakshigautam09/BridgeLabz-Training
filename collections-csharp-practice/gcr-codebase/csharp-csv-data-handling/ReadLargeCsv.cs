using System;
using System.IO;
using System.Collections.Generic;

class CSVChunkProcessor
{
    private string filePath;
    private const int CHUNK_SIZE = 100;

    public CSVChunkProcessor(string filePath)
    {
        this.filePath = filePath;
    }

    public void ProcessFile()
    {
        int totalRecordsProcessed = 0;
        List<string> buffer = new List<string>(CHUNK_SIZE);

        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    // Skip header
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    buffer.Add(line);

                    if (buffer.Count == CHUNK_SIZE)
                    {
                        ProcessChunk(buffer);
                        totalRecordsProcessed += buffer.Count;
                        buffer.Clear();
                    }
                }

                // Process remaining lines
                if (buffer.Count > 0)
                {
                    ProcessChunk(buffer);
                    totalRecordsProcessed += buffer.Count;
                }
            }

            Console.WriteLine("Total Records Processed: " + totalRecordsProcessed);
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading large CSV file.");
        }
    }

    private void ProcessChunk(List<string> lines)
    {
        // Simulated processing logic
        Console.WriteLine("Processed chunk of " + lines.Count + " records");
    }
}

class ReadLargeCsv
{
    static void Main()
    {
        CSVChunkProcessor processor =
            new CSVChunkProcessor("large_file.csv");

        processor.ProcessFile();
    }
}
