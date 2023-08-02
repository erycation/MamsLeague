using MamsLeagueApi.Models.Dtos;

namespace MamsLeagueApi.DomainLeague.Service.Interface
{
    public interface IPlayTimeService
    {
        Task<PlayTimeDto> AddPlayTime(PlayTimeDto playTimeDto);
        Task<List<PlayTimeDto>> GetAllPlayTimes();
        Task<PlayTimeDto> GetPlayTimeById(Guid playTimeId);
    }
}
