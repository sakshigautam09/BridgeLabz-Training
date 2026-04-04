using System;
using System.IO;
using System.Text;

class FilterStreams
{
    static void Main()
    {
        string sourceFile = "input.txt";
        string destinationFile = "output.txt";

        try
        {
            // FileStreams
            FileStream inputFile = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
            FileStream outputFile = new FileStream(destinationFile, FileMode.Create, FileAccess.Write);

            // BufferedStream
            BufferedStream bufferedInput = new BufferedStream(inputFile);
            BufferedStream bufferedOutput = new BufferedStream(outputFile);

            // StreamReader & StreamWriter
            StreamReader reader = new StreamReader(bufferedInput, Encoding.UTF8);
            StreamWriter writer = new StreamWriter(bufferedOutput, Encoding.UTF8);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }

            reader.Close();
            writer.Close();

            Console.WriteLine("File processed successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
