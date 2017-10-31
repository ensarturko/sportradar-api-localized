using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon.Data.Model.TeamStats
{
    public class PlayerSubStatistics : SimpleViewModel
    {
        public virtual GoalsScored goals_scored{ get; set; }
        public virtual CardsGiven cards_given { get; set; }
        public virtual ShotsOnGoal shots_on_goal{ get; set; }
        public virtual ShotsOffGoal shots_off_goal { get; set; }
        public virtual GoalsByHead goals_by_head { get; set; }
        public virtual GoalAttempts goal_attempts { get; set; }
    }
}
