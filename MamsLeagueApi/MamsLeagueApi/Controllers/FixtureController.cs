using MamsLeagueApi.DomainLeague.Service.Interface;
using MamsLeagueApi.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MamsLeagueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FixtureController : ControllerBase
    {
        private readonly IFixtureService _fixtureService;

        public FixtureController(IFixtureService fixtureService)
        {
            _fixtureService = fixtureService;
        }

        //[HttpGet("{schedulePlayId}")]
        //public async Task<IActionResult> GetSchedulePlayId(Guid schedulePlayId)
        //{
        //    var schedulePlayResults = await _schedulePlayService.GetSchedulePlayId(schedulePlayId);
        //    return Ok(schedulePlayResults);
        //}

        [HttpPost("Add")]
        public async Task<IActionResult> AddSchedulePlays([FromBody] FixtureDto fixtureDto)
        {
            var fixturesResults = await _fixtureService.AddFixture(fixtureDto);
            return Ok(new { message = "Schedule Added", data = fixturesResults });
        }

        [HttpGet("Schedule/{scheduleId}")]
        public async Task<IActionResult> GetAllSchedulePlays(Guid scheduleId)
        {
            var fixturesResults = await _fixtureService.GetFixturesByScheduleId(scheduleId);
            return Ok(fixturesResults);
        }

        [HttpGet("Results/{scheduleId}")]
        public async Task<IActionResult> GetResultsByScheduleId(Guid scheduleId)
        {
            var fixturesResults = await _fixtureService.GetResultsByScheduleId(scheduleId);
            return Ok(fixturesResults);
        }
    }
}
