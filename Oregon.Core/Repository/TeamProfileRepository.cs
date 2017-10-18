using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Oregon.Core.Infrastructure;
using Oregon.Data.DataContext;
using Oregon.Data.Model;

namespace Oregon.Core.Repository
{
    public class TeamProfileRepository : ITeamProfileRepository
    {
        private readonly SportContext _context = new SportContext();

        public IEnumerable<TeamProfileModel> GetAll()
        {
            return _context.TeamProfiles.Select(x => x);
        }

        public TeamProfileModel GetById(int id)
        {
            return _context.TeamProfiles.FirstOrDefault(x => x.Id == id);
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

        public void Update(TeamProfileModel obj)
        {
            _context.TeamProfiles.AddOrUpdate(obj);
        }

        public void Delete(int id)
        {
            var element = GetById(id);
            if (element != null)
            {
                _context.TeamProfiles.Remove(element);
            }
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
