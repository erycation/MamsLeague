using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamsLeagueApi.Models
{
    [Table("PlayTime")]
    public class PlayTime
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Time { get; set; }
    }
}
