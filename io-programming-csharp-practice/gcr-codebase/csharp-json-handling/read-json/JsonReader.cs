using System;
using System.IO;
using Newtonsoft.Json.Linq;

class JsonReader
{
    static void Main()
    {
        string json = File.ReadAllText("data.json");
        JObject obj = JObject.Parse(json);

        foreach (var property in obj.Properties())
        {
            Console.WriteLine(property.Name + " : " + property.Value);
        }
    }
}
