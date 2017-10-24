using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.Tournaments;

namespace Oregon.Data.Model.TournamentTeams
{
    public class Tournament : BaseTournamentModel
    {
        public Sport sport { get; set; }
        public Category category { get; set; }
        public CurrentSeason current_season { get; set; }
    }
}
