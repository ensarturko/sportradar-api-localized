using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model
{
    public class Venue : IBaseXmlModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string City_name { get; set; }
        public string Country_name { get; set; }
        public string Map_coordinates { get; set; }
        public string Country_code { get; set; }
    }
}
