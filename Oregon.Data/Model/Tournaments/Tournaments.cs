using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.Tournaments
{
    public class Tournaments
    {
        public DateTime generated_at { get; set; }
        public string schema { get; set; }
        public List<TournamentDetail> tournaments { get; set; }
    }
}
