using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.DataContext;
using Oregon.Data.Infrastructure;
using Oregon.Data.Model;
using Oregon.Data.Model.TeamStats;

namespace Oregon.Core.Infrastructure
{
    public interface ITeamStatsRepository : IRepository<TeamStats>
    {
       
    }
}
