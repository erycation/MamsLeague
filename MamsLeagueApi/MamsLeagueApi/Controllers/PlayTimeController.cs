using MamsLeagueApi.DomainLeague.Service.Interface;
using MamsLeagueApi.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MamsLeagueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayTimeController : ControllerBase
    {
        private readonly IPlayTimeService _playTimeService;

        public PlayTimeController(IPlayTimeService playTimeService)
        {
            _playTimeService = playTimeService;
        }

        [HttpGet("{playTimeId}")]
        public async Task<IActionResult> GetPlayTimeById(Guid playTimeId)
        {
            var schedulePlayResults = await _playTimeService.GetPlayTimeById(playTimeId);
            return Ok(schedulePlayResults);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllPlayTimes()
        {
            var schedulePlayResults = await _playTimeService.GetAllPlayTimes();
            return Ok(schedulePlayResults);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddPlayTime([FromBody] PlayTimeDto playTimeDto)
        {
            var schedulePlayResults = await _playTimeService.AddPlayTime(playTimeDto);
            return Ok(new { message = "Schedule Added", data = schedulePlayResults });
        }
    }
}
