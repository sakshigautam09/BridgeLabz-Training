using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class FileWriter
{
    public void WriteJson(string path, List<Match> matches)
    {
        string json = JsonConvert.SerializeObject(matches, Formatting.Indented);
        File.WriteAllText(path, json);
    }

    public void WriteCsv(string path, List<Match> matches)
    {
        var lines = new List<string>
        {
            "match_id,team1,team2,score_team1,score_team2,winner,player_of_match"
        };

        foreach (Match m in matches)
        {
            lines.Add(
                $"{m.MatchId},{m.Team1},{m.Team2}," +
                $"{m.Score[m.Team1]},{m.Score[m.Team2]}," +
                $"{m.Winner},{m.PlayerOfMatch}"
            );
        }

        File.WriteAllLines(path, lines);
    }
}
