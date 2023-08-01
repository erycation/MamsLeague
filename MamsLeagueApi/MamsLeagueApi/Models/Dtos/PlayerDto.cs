namespace MamsLeagueApi.Models.Dtos
{
    public class PlayerDto
    {
        public Guid Id { get; set; }
        public Guid TeamId { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public string? IdentityNumber { get; set; }
        public string? CardNumber { get; set; }
        public virtual TeamDto? TeamDto { get; set; }
    }
}
