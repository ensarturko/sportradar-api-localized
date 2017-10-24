using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Oregon.Data.Model.Tournaments;

namespace Oregon.Data.Model.TournamentTeams
{
    public class Team : BaseTournamentModel
    {
        public string country { get; set; }
        public string country_code { get; set; }
        public string abbreviation { get; set; }
    }
}
