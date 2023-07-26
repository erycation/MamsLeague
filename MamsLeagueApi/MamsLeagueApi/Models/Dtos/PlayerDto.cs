using System.ComponentModel.DataAnnotations;

namespace MamsLeagueApi.Models.Dtos
{
    public class PlayerDto
    {
        public Guid Id { get; set; }
        [Required]
        public Guid TeamId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public string CardNumber { get; set; }
        public virtual TeamDto? TeamDto { get; set; }
    }
}
