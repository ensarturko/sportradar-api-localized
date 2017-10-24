using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.Tournaments
{
    public class SeasonCoverageInfo
    {
        public string season_id { get; set; }
        public int scheduled { get; set; }
        public int played { get; set; }
        public string max_coverage_level { get; set; }
        public int max_covered { get; set; }
        public string min_coverage_level { get; set; }
    }
}
