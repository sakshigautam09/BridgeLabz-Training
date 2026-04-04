using System;
using System.IO;

class DataStreams
{
    static void Main()
    {
        string filePath = "student.dat";

        // Write data to binary file
        try
        {
            FileStream writeStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(writeStream);

            int rollNumber = 101;
            string name = "Rahul";
            double gpa = 8.7;

            writer.Write(rollNumber);
            writer.Write(name);
            writer.Write(gpa);

            writer.Close();
            writeStream.Close();

            Console.WriteLine("Student data written successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write Error: " + ex.Message);
        }

        // Read data from binary file
        try
        {
            FileStream readStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(readStream);

            int roll = reader.ReadInt32();
            string studentName = reader.ReadString();
            double studentGpa = reader.ReadDouble();

            reader.Close();
            readStream.Close();

            Console.WriteLine("\nStudent data read from file:");
            Console.WriteLine("Roll Number: " + roll);
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("GPA: " + studentGpa);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read Error: " + ex.Message);
        }
    }
}
