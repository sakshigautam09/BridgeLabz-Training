using System;
using System.IO;

class ByteArray
{
    static void Main()
    {
        string sourceImage = "input.jpg";
        string outputImage = "output.jpg";

        try
        {
            // Read image file into byte array
            byte[] imageBytes = File.ReadAllBytes(sourceImage);

            // Store byte array in MemoryStream
            MemoryStream memoryStream = new MemoryStream(imageBytes);

            // Write MemoryStream data to new image file
            FileStream fileStream = new FileStream(outputImage, FileMode.Create, FileAccess.Write);
            memoryStream.WriteTo(fileStream);

            memoryStream.Close();
            fileStream.Close();

            // Verify files are identical
            bool isSame = CompareFiles(sourceImage, outputImage);
            Console.WriteLine(isSame ? "Image copied successfully. Files are identical." : "Files are NOT identical.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }

    static bool CompareFiles(string file1, string file2)
    {
        byte[] first = File.ReadAllBytes(file1);
        byte[] second = File.ReadAllBytes(file2);

        if (first.Length != second.Length)
            return false;

        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
                return false;
        }

        return true;
    }
}
