using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.Data.Model.TeamStats
{
    public class TeamStats : SimpleViewModel
    {
        public DateTime generated_at { get; set; }
        public string schema { get; set; }
        public Tournament tournament { get; set; }
        public Team team { get; set; }
        public TeamSeasonCoverage team_season_coverage { get; set; }
        public TeamStatistics team_statistics { get; set; }
        public List<PlayerStatistic> player_statistics { get; set; }
        public GoaltimeStatistics goaltime_statistics { get; set; }
    }
}
