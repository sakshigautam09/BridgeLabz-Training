using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IFileReader jsonReader = new JsonFileReader();
        IFileReader csvReader = new CsvFileReader();

        List<Match> jsonMatches = jsonReader.Read("ipl.json");
        List<Match> csvMatches = csvReader.Read("ipl.csv");

        var censorshipService = new CensorshipService();
        censorshipService.ApplyCensorship(jsonMatches);
        censorshipService.ApplyCensorship(csvMatches);

        var writer = new FileWriter();
        writer.WriteJson("ipl_censored.json", jsonMatches);
        writer.WriteCsv("ipl_censored.csv", csvMatches);

        Console.WriteLine("Censorship completed successfully.");
    }
}
