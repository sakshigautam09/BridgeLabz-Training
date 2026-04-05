using System;
using Newtonsoft.Json.Linq;

class MergeJson
{
    static void Main()
    {
        JObject json1 = JObject.Parse(File.ReadAllText("file1.json"));
        JObject json2 = JObject.Parse(File.ReadAllText("file2.json"));

        json1.Merge(json2);
        Console.WriteLine(json1.ToString());
    }
}
