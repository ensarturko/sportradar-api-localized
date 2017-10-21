using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamProfile
{
    public class Jersey : SimpleViewModel
    {
        public string Type { get; set; }
        public string Base { get; set; }
        public string Sleeve { get; set; }
        public string Number { get; set; }
        public bool Squares { get; set; }
        public bool Stripes { get; set; }
        public string Stripes_color { get; set; }
        public bool Horizontal_stripes { get; set; }
        public bool Split { get; set; }
        public string Shirt_type { get; set; }
        public string Sleeve_detail { get; set; }
    }
}
