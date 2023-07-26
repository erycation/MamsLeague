using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MamsLeagueApi.Models
{
    [Table("SchedulePlay")]
    public class SchedulePlay
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [BindProperty, DataType(DataType.Date)]
        public DateTime ScheduleDate { get; set; } = DateTime.Now;
    }
}
