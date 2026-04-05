using System;
using Newtonsoft.Json;
using System.Xml;

class JsonToXml
{
    static void Main()
    {
        string json = File.ReadAllText("data.json");
        XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "Root");

        Console.WriteLine(doc.OuterXml);
    }
}
