using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class JsonFileReader : IFileReader
{
    public List<Match> Read(string path)
    {
        string json = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<List<Match>>(json);
    }
}
