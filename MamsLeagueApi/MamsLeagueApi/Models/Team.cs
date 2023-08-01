using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamsLeagueApi.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public Guid Id { get; set; }
        public string? TeamName { get; set; }
        public virtual ICollection<Player>? Players { get; set; }
    }
}
