using MamsLeagueApi.Models.Dtos;

namespace MamsLeagueApi.DomainLeague.Service.Interface
{
    public interface ITeamService
    {
        Task<List<TeamDto>> GetAllTeams();
        Task<TeamDto> GetTeamById(Guid teamId);
    }
}
