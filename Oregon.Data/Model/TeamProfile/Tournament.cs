using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Oregon.Data.Model.TeamProfile
{
    public class Tournament : SimpleViewModel
    {
        [JsonProperty("id")]
        public string TournamentId { get; set; }
        public Sport2 Sport { get; set; }
        public Category2 Category { get; set; }

    }
}
