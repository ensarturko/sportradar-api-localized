﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamProfile
{
    public class Player : IBaseXmlModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public string Date_of_birth { get; set; }
        public string Nationality { get; set; }
        public string Country_code { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Jersey_number { get; set; }
        public string Preferred_foot { get; set; }

    }
}
