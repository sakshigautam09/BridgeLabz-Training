using System;
using System.Diagnostics;
using System.IO;

class FileCopy
{
    static void Main()
    {
        string sourceFile = "largefile.dat";
        string normalCopy = "normal_copy.dat";
        string bufferedCopy = "buffered_copy.dat";

        CopyUsingFileStream(sourceFile, normalCopy);
        CopyUsingBufferedStream(sourceFile, bufferedCopy);
    }

    static void CopyUsingFileStream(string source, string destination)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        try
        {
            FileStream input = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream output = new FileStream(destination, FileMode.Create, FileAccess.Write);

            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }

            input.Close();
            output.Close();

            stopwatch.Stop();
            Console.WriteLine($"FileStream copy time: {stopwatch.ElapsedMilliseconds} ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }

    static void CopyUsingBufferedStream(string source, string destination)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        try
        {
            FileStream inputFile = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream outputFile = new FileStream(destination, FileMode.Create, FileAccess.Write);

            BufferedStream input = new BufferedStream(inputFile, 4096);
            BufferedStream output = new BufferedStream(outputFile, 4096);

            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }

            input.Close();
            output.Close();

            stopwatch.Stop();
            Console.WriteLine($"BufferedStream copy time: {stopwatch.ElapsedMilliseconds} ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
