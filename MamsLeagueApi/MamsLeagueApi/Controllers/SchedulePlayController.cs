using MamsLeagueApi.DomainLeague.Service.Interface;
using MamsLeagueApi.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MamsLeagueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulePlayController : ControllerBase
    {
        private readonly ISchedulePlayService _schedulePlayService;

        public SchedulePlayController(ISchedulePlayService schedulePlayService)
        {
            _schedulePlayService = schedulePlayService;
        }

        [HttpGet("{schedulePlayId}")]
        public async Task<IActionResult> GetSchedulePlayId(Guid schedulePlayId)
        {
            var schedulePlayResults = await _schedulePlayService.GetSchedulePlayId(schedulePlayId);
            return Ok(schedulePlayResults);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllSchedulePlays()
        {
            var schedulePlayResults = await _schedulePlayService.GetAllSchedulePlays();
            return Ok(schedulePlayResults);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddSchedulePlays([FromBody] SchedulePlayDto schedulePlayDto)
        {
            var schedulePlayResults = await _schedulePlayService.AddSchedulePlay(schedulePlayDto);
            return Ok(new { message = "Schedule Added", data = schedulePlayResults });
        }
    }
}
