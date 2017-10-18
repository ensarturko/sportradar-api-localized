using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamProfile
{
    public class Manager : IBaseXmlModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Country_code { get; set; }
    }
}
