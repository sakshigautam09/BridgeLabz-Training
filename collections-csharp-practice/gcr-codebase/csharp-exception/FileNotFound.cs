using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            using (FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
