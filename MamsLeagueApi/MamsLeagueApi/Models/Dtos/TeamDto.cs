namespace MamsLeagueApi.Models.Dtos
{
    public class TeamDto
    {
        public Guid Id { get; set; }
        public string? TeamName { get; set; }
        public virtual ICollection<PlayerDto>? PlayersDto { get; set; }
    }
}
