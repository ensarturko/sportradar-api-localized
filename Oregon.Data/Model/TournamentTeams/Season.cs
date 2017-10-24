using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.Tournaments;

namespace Oregon.Data.Model.TournamentTeams
{
    public class Season : BaseTournamentModel   
    {
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string year { get; set; }
        public string tournament_id { get; set; }
    }
}
