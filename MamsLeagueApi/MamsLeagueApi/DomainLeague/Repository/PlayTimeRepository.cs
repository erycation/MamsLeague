using MamsLeagueApi.DomainLeague.Persistance;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MamsLeagueApi.DomainLeague.Repository
{
    public class PlayTimeRepository : GenericRepository<PlayTime>, IPlayTimeRepository
    {
        private readonly DbSet<PlayTime> _playTimes;

        public PlayTimeRepository(MamsLeagueDBContext dbContext) : base(dbContext)
        {
            _playTimes = dbContext.Set<PlayTime>();
        }
    }
}
