using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.Data.Model.TeamStats
{
    public class PlayerStatistic : SimpleViewModel
    {
        public int matches_played { get; set; }
        public object statistics { get; set; }

        public string TeamId { get; set; }

        public PlayerStatistic()
        {
            Team t = new Team();
            this.TeamId = t.TeamId;
        }
    }
}
