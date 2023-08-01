using MamsLeagueApi.DomainLeague.Persistance;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MamsLeagueApi.DomainLeague.Repository
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        private readonly DbSet<Team> _team;

        public TeamRepository(MamsLeagueDBContext dbContext) : base(dbContext)
        {
            _team = dbContext.Set<Team>();
        }
    }
}
