using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamProfile
{
    public class Team : IBaseXmlModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Country_code { get; set; }
        public Sport Sport { get; set; }
        public Category Category { get; set; }
        public string Abbreviation { get; set; }

    }
}
