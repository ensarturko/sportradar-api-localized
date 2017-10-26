using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamStats
{
    public class TeamSeasonCoverage : SimpleViewModel
    {
        public int scheduled { get; set; }
        public int played { get; set; }
        public int gold { get; set; }
    }
}
