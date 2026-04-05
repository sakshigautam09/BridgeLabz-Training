using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class EmailValidation
{
    static void Main()
    {
        string jsonData = @"{ 'email': 'test@gmail.com' }";
        string schemaData = File.ReadAllText("schema.json");

        JObject jsonObject = JObject.Parse(jsonData);
        JSchema schema = JSchema.Parse(schemaData);

        bool isValid = jsonObject.IsValid(schema);
        Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
    }
}
