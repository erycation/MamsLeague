using MamsLeagueApi.Models.Dtos;

namespace MamsLeagueApi.DomainLeague.Service.Interface
{
    public interface IGroundService
    {
        Task<GroundDto> AddGround(GroundDto groundDto);
        Task<List<GroundDto>> GetAllGrounds();
        Task<GroundDto> GetGroundById(Guid groundId);
    }
}
