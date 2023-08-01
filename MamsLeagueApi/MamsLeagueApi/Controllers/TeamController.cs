using MamsLeagueApi.DomainLeague.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MamsLeagueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("{teamId}")]
        public async Task<IActionResult> GetTeamById(Guid teamId)
        {
            var teamResults = await _teamService.GetTeamById(teamId);
            return Ok(teamResults);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllTeams()
        {
            var teamResults = await _teamService.GetAllTeams();
            return Ok(teamResults);
        }

        /*
         * private readonly IFamilyInformationService _familyInformationService;
        private readonly IFamilyMemberService _familyMemberService;

        public FamilyController(IFamilyInformationService familyInformationService,
                                IFamilyMemberService familyMemberService)
        {
            _familyInformationService = familyInformationService;
            _familyMemberService = familyMemberService;
        }

        [HttpPost("Information/Add")]
        public async Task<IActionResult> CreateFamilyInformation([FromBody] FamilyInformationDto familyInformationDto)
        {
            var familyInformationResults = await _familyInformationService.CreateFamilyInformation(familyInformationDto);
            return Ok(new { message = "Successfully added", data = familyInformationResults });
        }

        [HttpPost("Information/AddUpdate")]
        public async Task<IActionResult> AddUpdateFamilyInformation([FromBody] FamilyInformationDto familyInformationDto)
        {
            var familyInformationResults = await _familyInformationService.AddUpdateFamilyInformation(familyInformationDto);
            return Ok(new { message = "Successfully added", data = familyInformationResults });
        }

        [HttpGet("Information/{familyInformationId}")]
        public async Task<IActionResult> GetFamilyInformationById(int familyInformationId)
        {
            var familyInformationResults = await _familyInformationService.GetFamilyInformationById(familyInformationId);
            return Ok(familyInformationResults);
        }

        */
    }
}
