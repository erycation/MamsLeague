namespace MamsLeagueApi.Models.Dtos
{
    public class LogStandingDto
    {
        public string? TeamName { get; set; }
        public int NumberGamePlayed { get; set; }
        public int Won { get; set; }
        public int Draw { get; set; }
        public int Loose { get; set; }
        public int GoalForward { get; set; }
        public int GoalAgainst { get; set; }
        public int GoalDiffer { get; set; }
        public int Points { get; set; }
    }
}
