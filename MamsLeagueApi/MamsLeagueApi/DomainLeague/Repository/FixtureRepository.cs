using MamsLeagueApi.DomainLeague.Persistance;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MamsLeagueApi.DomainLeague.Repository
{
    public class FixtureRepository : GenericRepository<Fixture>, IFixtureRepository
    {
        private readonly DbSet<Fixture> _fixture;

        public FixtureRepository(MamsLeagueDBContext dbContext) : base(dbContext)
        {
            _fixture = dbContext.Set<Fixture>();
        }

        public async Task<List<Fixture>> GetFixturesByScheduleId(Guid scheduleId)
        {
            return await _fixture.Where(c => c.SchedulePlayId == scheduleId).ToListAsync();
        }

        public async Task<List<Fixture>> GetResultsByScheduleId(Guid scheduleId)
        {
            return await _fixture.Where(c => c.SchedulePlayId == scheduleId && c.AwayTeamScore != null && c.HomeTeamScore != null).ToListAsync();
        }
    }
}
