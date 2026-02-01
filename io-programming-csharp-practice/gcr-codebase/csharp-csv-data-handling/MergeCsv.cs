using System;
using System.IO;
using System.Collections.Generic;

class StudentBasic
{
    public int Id;
    public string Name;
    public int Age;

    public StudentBasic(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

class CSVMerger
{
    private string file1;
    private string file2;
    private string outputFile;

    public CSVMerger(string file1, string file2, string outputFile)
    {
        this.file1 = file1;
        this.file2 = file2;
        this.outputFile = outputFile;
    }

    public void MergeFiles()
    {
        Dictionary<int, StudentBasic> studentsMap =
            new Dictionary<int, StudentBasic>();

        // Read students1.csv
        try
        {
            string[] lines = File.ReadAllLines(file1);

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                string[] data = lines[i].Split(',');

                int id = Convert.ToInt32(data[0]);
                string name = data[1];
                int age = Convert.ToInt32(data[2]);

                studentsMap[id] = new StudentBasic(id, name, age);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading students1.csv");
            return;
        }

        // Merge with students2.csv and write output
        try
        {
            string[] lines = File.ReadAllLines(file2);

            using (FileStream fs = new FileStream(outputFile, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade");

                for (int i = 1; i < lines.Length; i++) // skip header
                {
                    string[] data = lines[i].Split(',');

                    int id = Convert.ToInt32(data[0]);
                    int marks = Convert.ToInt32(data[1]);
                    string grade = data[2];

                    if (studentsMap.ContainsKey(id))
                    {
                        StudentBasic s = studentsMap[id];

                        writer.WriteLine(
                            s.Id + "," +
                            s.Name + "," +
                            s.Age + "," +
                            marks + "," +
                            grade
                        );
                    }
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error merging CSV files");
            return;
        }

        Console.WriteLine("CSV files merged successfully.");
    }
}

class MergeCsv
{
    static void Main()
    {
        CSVMerger merger = new CSVMerger(
            "students1.csv",
            "students2.csv",
            "merged_students.csv"
        );

        merger.MergeFiles();
    }
}
