using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.TeamStats;

namespace Oregon.Data.Model
{
    public class GoaltimeStatistics : SimpleViewModel
    {
        public Scored scored { get; set; }
        public Conceded conceded { get; set; }
    }
}
