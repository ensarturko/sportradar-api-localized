using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.Data.Model.TeamStats
{
    public class SimpleStatsModel : SimpleViewModel
    {
        public int total { get; set; }
        public int matches { get; set; }

        public string TeamId { get; set; }

        public SimpleStatsModel()
        {
            Team t = new Team();
            this.TeamId = t.TeamId;
        }
    }
}
