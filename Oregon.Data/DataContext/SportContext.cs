using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model;
using Oregon.Data.Model.TeamProfile;
using Oregon.Data.Model.TeamStats;
using Category = Oregon.Data.Model.TeamProfile.Category;
using Sport = Oregon.Data.Model.TeamProfile.Sport;
using Team = Oregon.Data.Model.TeamProfile.Team;
using Tournament = Oregon.Data.Model.TeamProfile.Tournament;

namespace Oregon.Data.DataContext
{
    public class SportContext : DbContext
    {
        public DbSet<TeamProfileModel> TeamProfiles { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Jersey> Jerseys { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Sport2> Sport2 { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<Statistics2> Statistics2 { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Category2> Category2 { get; set; }
        public DbSet<Venue> Venue { get; set; }

        public DbSet<TeamStats> TeamStats { get; set; }
        public DbSet<BallPossession> BallPossession { get; set; }
        public DbSet<CardsGiven> CardsGiven { get; set; }
        public DbSet<Conceded> Conceded { get; set; }
        public DbSet<CornerKicks> CornerKicks { get; set; }
        public DbSet<CurrentSeason> CurrentSeason { get; set; }
        public DbSet<FreeKicks> FreeKicks { get; set; }
        public DbSet<GoalAttempts> GoalAttempts { get; set; }
        public DbSet<GoalsByFoot> GoalsByFoot { get; set; }
        public DbSet<GoalsByHead> GoalsByHead { get; set; }
        public DbSet<GoalsConceded> GoalsConceded { get; set; }
        public DbSet<GoalsScored> GoalsScored { get; set; }
        public DbSet<GoaltimeStatistics> GoaltimeStatistics { get; set; }
        public DbSet<Offsides> Offsides { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistic { get; set; }
        public DbSet<Scored> Scored { get; set; }
        public DbSet<ShotsBlocked> ShotsBlocked { get; set; }
        public DbSet<ShotsOffGoal> ShotsOffGoal { get; set; }
        public DbSet<ShotsOnGoal> ShotsOnGoal { get; set; }
        public DbSet<TeamSeasonCoverage> TeamSeasonCoverage { get; set; }
        public DbSet<TeamStatistics> TeamStatistics { get; set; }
    }
}
