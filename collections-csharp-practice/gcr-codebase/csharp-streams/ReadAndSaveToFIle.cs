using System;
using System.IO;

class ReadAndSaveToFile
{
    static void Main()
    {
        string filePath = "user_info.txt";

        StreamReader reader = null;
        StreamWriter writer = null;

        try
        {
            reader = new StreamReader(Console.OpenStandardInput());
            writer = new StreamWriter(filePath);

            Console.Write("Enter your name: ");
            string name = reader.ReadLine();

            Console.Write("Enter your age: ");
            string age = reader.ReadLine();

            Console.Write("Enter your favorite programming language: ");
            string language = reader.ReadLine();

            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + language);

            Console.WriteLine("User information saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        finally
        {
            reader?.Close();
            writer?.Close();
        }
    }
}
