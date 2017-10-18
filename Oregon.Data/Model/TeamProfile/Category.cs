using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamProfile
{
    public class Category : IBaseXmlModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country_code { get; set; }
    }
}
