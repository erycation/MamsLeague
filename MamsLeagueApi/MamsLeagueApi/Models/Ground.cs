using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamsLeagueApi.Models
{
    [Table("Ground")]
    public class Ground
    {
        [Key]
        public Guid Id { get; set; }
        public string GroundName { get; set; }
    }
}
