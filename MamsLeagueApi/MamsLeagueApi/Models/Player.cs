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
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public string? IdentityNumber { get; set; }
        public string? CardNumber { get; set; }
        public virtual Team? Team { get; set; }
    }
}
