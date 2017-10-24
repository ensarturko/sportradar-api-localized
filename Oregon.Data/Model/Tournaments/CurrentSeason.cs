using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.Tournaments
{
    public class CurrentSeason : BaseTournamentModel
    {
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string year { get; set; }
    }
}
