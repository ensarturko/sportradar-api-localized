using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.Data.Model.TeamStats
{
    public class TeamStatistics : SimpleViewModel
    {
        public int matches_played { get; set; }
        public int matches_won { get; set; }
        public string form { get; set; }
        public virtual GoalAttempts goal_attempts { get; set; }
        public virtual ShotsOnGoal shots_on_goal { get; set; }
        public virtual ShotsOffGoal shots_off_goal { get; set; }
        public virtual CornerKicks corner_kicks { get; set; }
        public virtual BallPossession ball_possession { get; set; }
        public virtual ShotsBlocked shots_blocked { get; set; }
        public virtual CardsGiven cards_given { get; set; }
        public virtual FreeKicks free_kicks { get; set; }
        public virtual Offsides offsides { get; set; }
        public virtual GoalsByFoot goals_by_foot { get; set; }
        public virtual GoalsByHead goals_by_head { get; set; }
        public virtual GoalsScored goals_scored { get; set; }
        public virtual GoalsConceded goals_conceded { get; set; }
        public string TeamId { get; set; }

        public TeamStatistics()
        {
            Team t = new Team();
            this.TeamId = t.TeamId;
        }
    }
}
