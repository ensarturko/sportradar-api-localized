using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model;

namespace Oregon.Data.DataContext
{
    public class SportContext : DbContext
    {
        public DbSet<TeamProfileModel> TeamProfiles { get; set; }
    } 
}
