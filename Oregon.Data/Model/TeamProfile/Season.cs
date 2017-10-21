using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Oregon.Data.Model.TeamProfile
{
    public class Season : SimpleViewModel
    {
        [JsonProperty("id")]
        public string SeasonId { get; set; }
        public Statistics2 Statistics { get; set; }
        public Tournament Tournament { get; set; }
        public Form Form { get; set; }
    }
}
