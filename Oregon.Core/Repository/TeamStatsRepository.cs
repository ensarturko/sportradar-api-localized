using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Oregon.Core.Infrastructure;
using Oregon.Data.DataContext;
using Oregon.Data.Infrastructure;
using Oregon.Data.Model;
using Oregon.Data.Model.TeamStats;

namespace Oregon.Core.Repository
{
    public class TeamStatsRepository : ITeamStatsRepository
    {
        private readonly SportContext _context = new SportContext();

        public IEnumerable<TeamStats> GetAll()
        {
            return _context.TeamStats.Select(x => x);
        }

        public TeamStats Get(Expression<Func<TeamStats, bool>> expression)
        {
            return _context.TeamStats.FirstOrDefault(expression);
        }

        public IQueryable<TeamStats> GetMany(Expression<Func<TeamStats, bool>> expression)
        {
            return _context.TeamStats.Where(expression);
        }

        public void Insert(TeamStats obj)
        {
            _context.TeamStats.Add(obj);
        }

        public TeamProfileModel GetById(int id)
        {
            return _context.TeamProfiles.Include("Manager").Include("Statistics").Include("Team").Include("Venue").FirstOrDefault(x => x.Id == id);
        }

        public TeamStats GetByStatsId(int id)
        {
            return _context.TeamStats.FirstOrDefault(x => x.Id == id);
        }

        public void Update(TeamStats obj)
        {
            _context.TeamStats.AddOrUpdate(obj);
        }

        TeamProfileModel IRepository<TeamStats>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            return _context.TeamStats.Count();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
