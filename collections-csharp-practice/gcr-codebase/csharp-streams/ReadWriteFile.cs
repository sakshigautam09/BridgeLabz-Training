using System;
using System.IO;
class ReadWriteFile
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            FileStream input = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
            FileStream output = new FileStream(destinationFile, FileMode.Create, FileAccess.Write);

            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }

            input.Close();
            output.Close();

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
