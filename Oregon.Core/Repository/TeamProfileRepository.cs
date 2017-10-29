using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Oregon.Core.Infrastructure;
using Oregon.Data.DataContext;
using Oregon.Data.Model;
using Oregon.Data.Model.TeamProfile;
using Oregon.Data.Model.TeamStats;

namespace Oregon.Core.Repository
{
    public class TeamProfileRepository : ITeamProfileRepository
    {
        private readonly SportContext _context = new SportContext();

        public IEnumerable<TeamProfileModel> GetAll()
        {
            return _context.TeamProfiles.Include("Manager").Include("Statistics").Include("Team").Include("Venue").Select(x => x);
        }

        public TeamProfileModel Get(Expression<Func<TeamProfileModel, bool>> expression)
        {
            return _context.TeamProfiles.FirstOrDefault(expression);
        }

        public IQueryable<TeamProfileModel> GetMany(Expression<Func<TeamProfileModel, bool>> expression)
        {
            return _context.TeamProfiles.Where(expression);
        }

        public void Insert(TeamProfileModel obj)
        {
            _context.TeamProfiles.Add(obj);
        }

        public TeamProfileModel GetById(int? id)
        {
            return _context.TeamProfiles.Include("Manager").Include("Statistics").Include("Team").Include("Venue").FirstOrDefault(x => x.Id == id);
        }

        public List<Category> GetCategoryInfo()
        {
            return _context.Categories.ToList();
        }

        public TeamStats GetByStatsId(int id)
        {
            return _context.TeamStats.FirstOrDefault(x => x.Id == id);
        }

        public List<Team> GetAllTeams()
        {
            return _context.Teams.ToList();
        }

        public void Update(TeamProfileModel obj)
        {
            _context.TeamProfiles.AddOrUpdate(obj);
        }

        public int Count()
        {
            return _context.TeamProfiles.Count();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
