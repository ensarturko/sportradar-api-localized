using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.Tournaments;

namespace Oregon.Data.Model.TournamentTeams
{
    public class TournamentTeams
    {
        public DateTime generated_at { get; set; }
        public string schema { get; set; }
        public Tournament tournament { get; set; }
        public Season season { get; set; }
        public Round round { get; set; }
        public SeasonCoverageInfo season_coverage_info { get; set; }
        public CoverageInfo coverage_info { get; set; }
        public List<Group> groups { get; set; }
    }
}
