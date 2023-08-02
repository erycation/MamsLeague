using MamsLeagueApi.DomainLeague.Persistance;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MamsLeagueApi.DomainLeague.Repository
{
    public class GroundRepository : GenericRepository<Ground>, IGroundRepository
    {
        private readonly DbSet<Ground> _ground;

        public GroundRepository(MamsLeagueDBContext dbContext) : base(dbContext)
        {
            _ground = dbContext.Set<Ground>();
        }
    }
}
