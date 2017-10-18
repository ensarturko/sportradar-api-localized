using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Infrastructure;
using Oregon.Data.Model;

namespace Oregon.Core.Infrastructure
{
    public interface ITeamProfileRepository : IRepository<TeamProfileModel>
    {
    }
}
