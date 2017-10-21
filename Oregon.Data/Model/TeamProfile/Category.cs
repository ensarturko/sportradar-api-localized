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
    public class Category : SimpleViewModel
    {
        [JsonProperty("id")]
        public string CategoryId { get; set; }
        public string Country_code { get; set; }
    }
}
