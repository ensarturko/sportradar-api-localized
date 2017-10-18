using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamProfile
{
    public class Tournament : IBaseXmlModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Sport2 Sport { get; set; }
        public Category2 Category { get; set; }

    }
}
