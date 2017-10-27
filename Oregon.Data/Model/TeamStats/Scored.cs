using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.Data.Model.TeamStats
{
    public class Scored : SimpleViewModel
    {
        public int total { get; set; }
        public List<Period> period { get; set; }

        public string TeamId { get; set; }

        public Scored()
        {
            Team t = new Team();
            this.TeamId = t.TeamId;
        }
    }
}
