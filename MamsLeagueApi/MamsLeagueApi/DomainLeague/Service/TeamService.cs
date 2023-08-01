using AutoMapper;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.DomainLeague.Service.Interface;
using MamsLeagueApi.Models.Dtos;

namespace MamsLeagueApi.DomainLeague.Service
{
    public class TeamService : ITeamService
    {
        private readonly IMapper _mapper;
        private readonly ITeamRepository _teamRepository;

        public TeamService(IMapper mapper,
                           ITeamRepository teamRepository)
        {
            _mapper = mapper;
            _teamRepository = teamRepository;
        }

        public async Task<List<TeamDto>> GetAllTeams()
        {
            var teamResponse = await _teamRepository.GetAllAsync();
            return _mapper.Map<List<TeamDto>>(teamResponse.OrderByDescending(t => t.TeamName));
        }

        public async Task<TeamDto> GetTeamById(Guid teamId)
        {
            var teamResponse = await _teamRepository.GetByIdAsync(teamId);
            return _mapper.Map<TeamDto>(teamResponse);
        }
    }
}
