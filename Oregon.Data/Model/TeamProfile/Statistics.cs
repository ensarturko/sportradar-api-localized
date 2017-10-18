using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamProfile
{
    public class Statistics : IBaseXmlModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Season> Seasons { get; set; }
    }
}
