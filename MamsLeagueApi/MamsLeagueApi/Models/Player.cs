using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamsLeagueApi.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public Guid Id { get; set; }
        public Guid TeamId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public string CardNumber { get; set; }
        public virtual Team? Team { get; set; }
    }
}
