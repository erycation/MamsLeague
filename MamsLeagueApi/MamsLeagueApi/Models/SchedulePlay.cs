using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamsLeagueApi.Models
{
    [Table("SchedulePlay")]
    public class SchedulePlay
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime ScheduleDate { get; set; } = DateTime.Now;
    }
}
