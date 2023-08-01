using MamsLeagueApi.Models.Dtos;

namespace MamsLeagueApi.DomainLeague.Service.Interface
{
    public interface ISchedulePlayService
    {
        Task<SchedulePlayDto> AddSchedulePlay(SchedulePlayDto schedulePlayDto);
        Task<List<SchedulePlayDto>> GetAllSchedulePlays();
        Task<SchedulePlayDto> GetSchedulePlayId(Guid schedulePlayId);
    }
}
