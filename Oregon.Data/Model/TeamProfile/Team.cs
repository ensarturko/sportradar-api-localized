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
    public class Team : SimpleViewModel
    {
        [JsonProperty("id")]
        public string TeamId { get; set; }
        public string Country { get; set; }
        public string Country_code { get; set; }
        public Sport Sport { get; set; }
        public Category Category { get; set; }
        public string Abbreviation { get; set; }
    }
}
