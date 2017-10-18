using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.Data.Model
{
    public class TeamProfileModel
    {
        public DateTime Generated_at { get; set; }
        public string Schema { get; set; }
        public Team Team { get; set; }
        public Venue Venue { get; set; }
        public List<Jersey> Jerseys { get; set; }
        public Manager Manager { get; set; }
        public List<Player> Players { get; set; }
        public Statistics Statistics { get; set; }
    }
}
