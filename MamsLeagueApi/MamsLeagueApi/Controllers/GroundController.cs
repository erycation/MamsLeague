using MamsLeagueApi.DomainLeague.Service.Interface;
using MamsLeagueApi.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MamsLeagueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroundController : ControllerBase
    {
        private readonly IGroundService _groundService;

        public GroundController(IGroundService groundService)
        {
            _groundService = groundService;
        }

        [HttpGet("{groundId}")]
        public async Task<IActionResult> GetGroundById(Guid groundId)
        {
            var groundResults = await _groundService.GetGroundById(groundId);
            return Ok(groundResults);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllGrounds()
        {
            var groundResults = await _groundService.GetAllGrounds();
            return Ok(groundResults);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddGround([FromBody] GroundDto groundDto)
        {
            var groundResults = await _groundService.AddGround(groundDto);
            return Ok(new { message = "Schedule Added", data = groundResults });
        }
    }
}
