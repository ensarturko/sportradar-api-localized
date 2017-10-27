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
        public GoalAttempts goal_attempts { get; set; }
        public ShotsOnGoal shots_on_goal { get; set; }
        public ShotsOffGoal shots_off_goal { get; set; }
        public CornerKicks corner_kicks { get; set; }
        public BallPossession ball_possession { get; set; }
        public ShotsBlocked shots_blocked { get; set; }
        public CardsGiven cards_given { get; set; }
        public FreeKicks free_kicks { get; set; }
        public Offsides offsides { get; set; }
        public GoalsByFoot goals_by_foot { get; set; }
        public GoalsByHead goals_by_head { get; set; }
        public GoalsScored goals_scored { get; set; }
        public GoalsConceded goals_conceded { get; set; }
        public string TeamId { get; set; }

        public TeamStatistics()
        {
            Team t = new Team();
            this.TeamId = t.TeamId;
        }
    }
}
