using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamsLeagueApi.Models
{
    [Table("MatchResult")]
    public class MatchResult
    {
        [Key]
        public Guid Id { get; set; }
        public Guid FixtureId { get; set; }
        public Guid TeamId { get; set; }
        public int Score { get; set; }
        public virtual Fixture? Fixture { get; set; }
        public virtual Team? Team { get; set; }
    }
}
