using System.ComponentModel.DataAnnotations;

namespace MamsLeagueApi.Models.Dtos
{
    public class FixtureDto
    {
        public Guid Id { get; set; }
        [Required]
        public Guid SchedulePlayId { get; set; }
        [Required]
        public Guid GroundId { get; set; }
        [Required]
        public Guid PlayTimeId { get; set; }
        [Required]
        public Guid AwayTeamId { get; set; }
        public int? AwayTeamScore { get; set; }
        [Required]
        public Guid HomeTeamId { get; set; }
        public int? HomeTeamScore { get; set; }
        public virtual TeamDto? AwayTeamDto { get; set; }
        public virtual GroundDto? GroundDto { get; set; }
        //[InverseProperty("HomeTeamId")]
        public virtual TeamDto? HomeTeamDto { get; set; }
        public virtual PlayTimeDto? PlayTimeDto { get; set; }
        public virtual SchedulePlayDto? SchedulePlayDto { get; set; }
    }
}
