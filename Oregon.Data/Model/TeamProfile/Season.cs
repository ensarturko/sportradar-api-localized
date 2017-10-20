using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamProfile
{
    public class Season : IBaseXmlModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Statistics2 Statistics { get; set; }
        public Tournament Tournament { get; set; }
        public Form Form { get; set; }
    }
}
