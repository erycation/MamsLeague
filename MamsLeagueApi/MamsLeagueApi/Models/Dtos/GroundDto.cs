using System.ComponentModel.DataAnnotations;

namespace MamsLeagueApi.Models.Dtos
{
    public class GroundDto
    {
        public Guid Id { get; set; }
        [Required]
        public string GroundName { get; set; }
    }
}
