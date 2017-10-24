using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.Tournaments
{
    public class TournamentDetail
    {
        public string id { get; set; }
        public string name { get; set; }
        public Sport sport { get; set; }
        public Category category{ get; set; }
        public CurrentSeason current_season { get; set; }
        public SeasonCoverageInfo season_coverage_info { get; set; }
    }
}
