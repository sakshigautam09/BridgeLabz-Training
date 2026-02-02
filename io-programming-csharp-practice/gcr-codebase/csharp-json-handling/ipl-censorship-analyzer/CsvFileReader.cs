using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class CsvFileReader : IFileReader
{
    public List<Match> Read(string path)
    {
        var matches = new List<Match>();
        var lines = File.ReadAllLines(path).Skip(1);

        foreach (string line in lines)
        {
            string[] data = line.Split(',');

            var score = new Dictionary<string, int>
            {
                { data[1], int.Parse(data[3]) },
                { data[2], int.Parse(data[4]) }
            };

            matches.Add(new Match
            {
                MatchId = int.Parse(data[0]),
                Team1 = data[1],
                Team2 = data[2],
                Score = score,
                Winner = data[5],
                PlayerOfMatch = data[6]
            });
        }
        return matches;
    }
}
