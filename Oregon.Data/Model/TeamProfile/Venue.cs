using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Oregon.Data.Model
{
    public class Venue : SimpleViewModel
    {
        [JsonProperty("id")]
        public string VenueId { get; set; }
        public int Capacity { get; set; }
        public string City_name { get; set; }
        public string Country_name { get; set; }
        public string Map_coordinates { get; set; }
        public string Country_code { get; set; }
    }
}
