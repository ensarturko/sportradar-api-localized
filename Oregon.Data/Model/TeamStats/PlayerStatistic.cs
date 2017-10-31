using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.Data.Model.TeamStats
{
    public class PlayerStatistic : SimpleViewModel
    {
        [JsonProperty("id")]
        public string PlayerId { get; set; }
        public int matches_played { get; set; }
        
        // object will replace with List<PlayerSubStatistics> then. 
        public virtual object statistics { get; set; }

        public string TeamId { get; set; }

        public PlayerStatistic()
        {
            Team t = new Team();
            this.TeamId = t.TeamId;
        }
    }
}
