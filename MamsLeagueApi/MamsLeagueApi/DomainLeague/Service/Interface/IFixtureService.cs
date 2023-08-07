using MamsLeagueApi.Models.Dtos;

namespace MamsLeagueApi.DomainLeague.Service.Interface
{
    public interface IFixtureService
    {
        Task<FixtureDto> AddFixture(FixtureDto fixtureDto);
        Task<List<FixtureDto>> GetFixturesByScheduleId(Guid scheduleId);
        Task<List<FixtureDto>> GetResultsByScheduleId(Guid scheduleId);
        Task<FixtureDto> AddResults(FixtureDto fixtureDto);
    }
}
