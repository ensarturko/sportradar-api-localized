using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.Data.Model.TeamStats
{
    public class TeamSeasonCoverage : SimpleViewModel
    {
        public int scheduled { get; set; }
        public int played { get; set; }
        public int gold { get; set; }

        public string TeamId { get; set; }

        public TeamSeasonCoverage()
        {
            Team t = new Team();
            this.TeamId = t.TeamId;
        }
    }
}
