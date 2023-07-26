using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamsLeagueApi.Models
{
    [Table("Fixture")]
    public class Fixture
    {
       
        public Fixture()
        {
            this.MatchResults = new HashSet<MatchResult>();
        }

        [Key]
        public Guid Id { get; set; }
        public Guid SchedulePlayId { get; set; }
        public Guid GroundId { get; set; }
        public Guid PlayTimeId { get; set; }       
        public Guid AwayTeamId { get; set; }
        public int? AwayTeamScore { get; set; }
        public Guid HomeTeamId { get; set; }
        public int? HomeTeamScore { get; set; }
        //[InverseProperty("AwayTeamId")]
        public virtual Team? AwayTeam { get; set; }
        public virtual Ground? Ground { get; set; }
        //[InverseProperty("HomeTeamId")]
        public virtual Team? HomeTeam { get; set; }
        public virtual PlayTime? PlayTime { get; set; }
        public virtual SchedulePlay? SchedulePlay { get; set; }
        public virtual ICollection<MatchResult> MatchResults { get; set; }
    }
}
