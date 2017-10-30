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
        public virtual Scored scored { get; set; }
        public virtual Conceded conceded { get; set; }
    }
}
