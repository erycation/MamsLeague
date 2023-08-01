using MamsLeagueApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MamsLeagueApi.DomainLeague.Persistance
{
    public class MamsLeagueDBContext : DbContext
    {
        public MamsLeagueDBContext(DbContextOptions<MamsLeagueDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<LogStanding>().HasNoKey();
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<SchedulePlay> SchedulePlays { get; set; }

        /*
        public DbSet<AuthUser> AuthUsers { get; set; }
        
        
        public DbSet<Ground> Grounds { get; set; }
        public DbSet<MatchResult> MatchResults { get; set; }
        public DbSet<PlayTime> PlayTimes { get; set; }
        public DbSet<SchedulePlay> SchedulePlays { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<LogStanding> LogStandings { get; set; }
        */
    }
}


