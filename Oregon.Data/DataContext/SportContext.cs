using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model;
using Oregon.Data.Model.TeamProfile;

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
    }
}
