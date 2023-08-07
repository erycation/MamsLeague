using MamsLeagueApi.DomainLeague.Persistance;
using MamsLeagueApi.Models;

namespace MamsLeagueApi.DomainLeague.Repository.Interface
{
    public interface IFixtureRepository : IGenericRepository<Fixture>
    {
        Task<List<Fixture>> GetFixturesByScheduleId(Guid scheduleId);
        Task<List<Fixture>> GetResultsByScheduleId(Guid scheduleId);
    }
}
