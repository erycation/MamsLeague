using System.ComponentModel.DataAnnotations;

namespace MamsLeagueApi.Models.Dtos
{
    public class PlayTimeDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Time { get; set; }        
    }
}
