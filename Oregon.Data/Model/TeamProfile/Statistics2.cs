using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamProfile
{
    public class Statistics2 : SimpleViewModel
    {
        public int Matches_played { get; set; }
        public int Matches_won { get; set; }
        public int Matches_drawn { get; set; }
        public int Matches_lost { get; set; }
        public int Goals_scored { get; set; }
        public int Goals_conceded { get; set; }
        public int Group_position { get; set; }
        public int? Cup_rank { get; set; }
        public string Group_name { get; set; }
    }
}
