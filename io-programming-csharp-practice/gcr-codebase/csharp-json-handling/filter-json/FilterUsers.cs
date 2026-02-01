using System;
using Newtonsoft.Json.Linq;

class FilterUsers
{
    static void Main()
    {
        string json = File.ReadAllText("users.json");
        JArray users = JArray.Parse(json);

        foreach (JObject user in users)
        {
            if ((int)user["age"] > 25)
            {
                Console.WriteLine(user["name"]);
            }
        }
    }
}
