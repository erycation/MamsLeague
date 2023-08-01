using MamsLeagueApi.DomainLeague.Persistance;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MamsLeagueApi.DomainLeague.Repository
{
    public class SchedulePlayRepository : GenericRepository<SchedulePlay>, ISchedulePlayRepository
    {
        private readonly DbSet<SchedulePlay> _schedulePlay;

        public SchedulePlayRepository(MamsLeagueDBContext dbContext) : base(dbContext)
        {
            _schedulePlay = dbContext.Set<SchedulePlay>();
        }
    }
}
