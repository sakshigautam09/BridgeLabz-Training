using System.Collections.Generic;

sealed class CensorshipService
{
    public void ApplyCensorship(List<Match> matches)
    {
        foreach (Match match in matches)
        {
            string maskedTeam1 = MaskTeam(match.Team1);
            string maskedTeam2 = MaskTeam(match.Team2);

            var newScore = new Dictionary<string, int>
            {
                { maskedTeam1, match.Score[match.Team1] },
                { maskedTeam2, match.Score[match.Team2] }
            };

            match.Team1 = maskedTeam1;
            match.Team2 = maskedTeam2;
            match.Score = newScore;
            match.Winner = MaskTeam(match.Winner);
            match.PlayerOfMatch = "REDACTED";
        }
    }

    private string MaskTeam(string team)
    {
        string[] parts = team.Split(' ');
        if (parts.Length >= 2)
        {
            parts[1] = "***";
        }
        return string.Join(" ", parts);
    }
}
