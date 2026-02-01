using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

class CsvToJson
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("data.csv");
        var data = new List<Dictionary<string, string>>();

        string[] headers = lines[0].Split(',');

        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');
            var obj = new Dictionary<string, string>();

            for (int j = 0; j < headers.Length; j++)
            {
                obj[headers[j]] = values[j];
            }

            data.Add(obj);
        }

        string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        Console.WriteLine(json);
    }
}
