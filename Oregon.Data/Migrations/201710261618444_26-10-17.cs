namespace Oregon.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _261017 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BallPossessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CardsGivens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.String(),
                        Country_code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Category2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category2Id = c.String(),
                        Country_code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Concededs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Periods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        value = c.Int(nullable: false),
                        Name = c.String(),
                        Conceded_Id = c.Int(),
                        Scored_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Concededs", t => t.Conceded_Id)
                .ForeignKey("dbo.Scoreds", t => t.Scored_Id)
                .Index(t => t.Conceded_Id)
                .Index(t => t.Scored_Id);
            
            CreateTable(
                "dbo.CornerKicks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CurrentSeasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        start_date = c.String(),
                        end_date = c.String(),
                        year = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.String(),
                        Home = c.String(),
                        Away = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FreeKicks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoalAttempts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoalsByFeet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoalsByHeads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoalsConcededs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoalsScoreds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoaltimeStatistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        conceded_Id = c.Int(),
                        scored_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Concededs", t => t.conceded_Id)
                .ForeignKey("dbo.Scoreds", t => t.scored_Id)
                .Index(t => t.conceded_Id)
                .Index(t => t.scored_Id);
            
            CreateTable(
                "dbo.Scoreds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jerseys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Base = c.String(),
                        Sleeve = c.String(),
                        Number = c.String(),
                        Squares = c.Boolean(nullable: false),
                        Stripes = c.Boolean(nullable: false),
                        Stripes_color = c.String(),
                        Horizontal_stripes = c.Boolean(nullable: false),
                        Split = c.Boolean(nullable: false),
                        Shirt_type = c.String(),
                        Sleeve_detail = c.String(),
                        Name = c.String(),
                        TeamProfileModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TeamProfileModels", t => t.TeamProfileModel_Id)
                .Index(t => t.TeamProfileModel_Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManagerId = c.String(),
                        Nationality = c.String(),
                        Country_code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Offsides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.String(),
                        type = c.String(),
                        Date_of_birth = c.String(),
                        Nationality = c.String(),
                        Country_code = c.String(),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Jersey_number = c.Int(nullable: false),
                        Preferred_foot = c.String(),
                        Name = c.String(),
                        TeamProfileModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TeamProfileModels", t => t.TeamProfileModel_Id)
                .Index(t => t.TeamProfileModel_Id);
            
            CreateTable(
                "dbo.PlayerStatistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        matches_played = c.Int(nullable: false),
                        Name = c.String(),
                        TeamStats_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TeamStats", t => t.TeamStats_Id)
                .Index(t => t.TeamStats_Id);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeasonId = c.String(),
                        Name = c.String(),
                        Form_Id = c.Int(),
                        Statistics_Id = c.Int(),
                        Tournament_Id = c.Int(),
                        Statistics_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forms", t => t.Form_Id)
                .ForeignKey("dbo.Statistics2", t => t.Statistics_Id)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id)
                .ForeignKey("dbo.Statistics", t => t.Statistics_Id1)
                .Index(t => t.Form_Id)
                .Index(t => t.Statistics_Id)
                .Index(t => t.Tournament_Id)
                .Index(t => t.Statistics_Id1);
            
            CreateTable(
                "dbo.Statistics2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matches_played = c.Int(nullable: false),
                        Matches_won = c.Int(nullable: false),
                        Matches_drawn = c.Int(nullable: false),
                        Matches_lost = c.Int(nullable: false),
                        Goals_scored = c.Int(nullable: false),
                        Goals_conceded = c.Int(nullable: false),
                        Group_position = c.Int(nullable: false),
                        Cup_rank = c.Int(),
                        Group_name = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TournamentId = c.String(),
                        Name = c.String(),
                        Category_Id = c.Int(),
                        Sport_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category2", t => t.Category_Id)
                .ForeignKey("dbo.Sport2", t => t.Sport_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Sport_Id);
            
            CreateTable(
                "dbo.Sport2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sport2Id = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShotsBlockeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShotsOffGoals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShotsOnGoals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        total = c.Int(nullable: false),
                        matches = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportId = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Statistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamProfileModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Generated_at = c.DateTime(nullable: false),
                        Schema = c.String(),
                        Name = c.String(),
                        Manager_Id = c.Int(),
                        Statistics_Id = c.Int(),
                        Team_Id = c.Int(),
                        Venue_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Managers", t => t.Manager_Id)
                .ForeignKey("dbo.Statistics", t => t.Statistics_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.Venues", t => t.Venue_Id)
                .Index(t => t.Manager_Id)
                .Index(t => t.Statistics_Id)
                .Index(t => t.Team_Id)
                .Index(t => t.Venue_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.String(),
                        Country = c.String(),
                        Country_code = c.String(),
                        Abbreviation = c.String(),
                        Name = c.String(),
                        Category_Id = c.Int(),
                        Sport_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Sports", t => t.Sport_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Sport_Id);
            
            CreateTable(
                "dbo.Venues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VenueId = c.String(),
                        Capacity = c.Int(nullable: false),
                        City_name = c.String(),
                        Country_name = c.String(),
                        Map_coordinates = c.String(),
                        Country_code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamSeasonCoverages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        scheduled = c.Int(nullable: false),
                        played = c.Int(nullable: false),
                        gold = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamStatistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        matches_played = c.Int(nullable: false),
                        matches_won = c.Int(nullable: false),
                        form = c.String(),
                        Name = c.String(),
                        ball_possession_Id = c.Int(),
                        cards_given_Id = c.Int(),
                        corner_kicks_Id = c.Int(),
                        free_kicks_Id = c.Int(),
                        goal_attempts_Id = c.Int(),
                        goals_by_foot_Id = c.Int(),
                        goals_by_head_Id = c.Int(),
                        goals_conceded_Id = c.Int(),
                        goals_scored_Id = c.Int(),
                        offsides_Id = c.Int(),
                        shots_blocked_Id = c.Int(),
                        shots_off_goal_Id = c.Int(),
                        shots_on_goal_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BallPossessions", t => t.ball_possession_Id)
                .ForeignKey("dbo.CardsGivens", t => t.cards_given_Id)
                .ForeignKey("dbo.CornerKicks", t => t.corner_kicks_Id)
                .ForeignKey("dbo.FreeKicks", t => t.free_kicks_Id)
                .ForeignKey("dbo.GoalAttempts", t => t.goal_attempts_Id)
                .ForeignKey("dbo.GoalsByFeet", t => t.goals_by_foot_Id)
                .ForeignKey("dbo.GoalsByHeads", t => t.goals_by_head_Id)
                .ForeignKey("dbo.GoalsConcededs", t => t.goals_conceded_Id)
                .ForeignKey("dbo.GoalsScoreds", t => t.goals_scored_Id)
                .ForeignKey("dbo.Offsides", t => t.offsides_Id)
                .ForeignKey("dbo.ShotsBlockeds", t => t.shots_blocked_Id)
                .ForeignKey("dbo.ShotsOffGoals", t => t.shots_off_goal_Id)
                .ForeignKey("dbo.ShotsOnGoals", t => t.shots_on_goal_Id)
                .Index(t => t.ball_possession_Id)
                .Index(t => t.cards_given_Id)
                .Index(t => t.corner_kicks_Id)
                .Index(t => t.free_kicks_Id)
                .Index(t => t.goal_attempts_Id)
                .Index(t => t.goals_by_foot_Id)
                .Index(t => t.goals_by_head_Id)
                .Index(t => t.goals_conceded_Id)
                .Index(t => t.goals_scored_Id)
                .Index(t => t.offsides_Id)
                .Index(t => t.shots_blocked_Id)
                .Index(t => t.shots_off_goal_Id)
                .Index(t => t.shots_on_goal_Id);
            
            CreateTable(
                "dbo.TeamStats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        generated_at = c.DateTime(nullable: false),
                        schema = c.String(),
                        Name = c.String(),
                        goaltime_statistics_Id = c.Int(),
                        team_Id = c.Int(),
                        team_season_coverage_Id = c.Int(),
                        team_statistics_Id = c.Int(),
                        tournament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GoaltimeStatistics", t => t.goaltime_statistics_Id)
                .ForeignKey("dbo.Teams", t => t.team_Id)
                .ForeignKey("dbo.TeamSeasonCoverages", t => t.team_season_coverage_Id)
                .ForeignKey("dbo.TeamStatistics", t => t.team_statistics_Id)
                .ForeignKey("dbo.Tournaments", t => t.tournament_Id)
                .Index(t => t.goaltime_statistics_Id)
                .Index(t => t.team_Id)
                .Index(t => t.team_season_coverage_Id)
                .Index(t => t.team_statistics_Id)
                .Index(t => t.tournament_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamStats", "tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.TeamStats", "team_statistics_Id", "dbo.TeamStatistics");
            DropForeignKey("dbo.TeamStats", "team_season_coverage_Id", "dbo.TeamSeasonCoverages");
            DropForeignKey("dbo.TeamStats", "team_Id", "dbo.Teams");
            DropForeignKey("dbo.PlayerStatistics", "TeamStats_Id", "dbo.TeamStats");
            DropForeignKey("dbo.TeamStats", "goaltime_statistics_Id", "dbo.GoaltimeStatistics");
            DropForeignKey("dbo.TeamStatistics", "shots_on_goal_Id", "dbo.ShotsOnGoals");
            DropForeignKey("dbo.TeamStatistics", "shots_off_goal_Id", "dbo.ShotsOffGoals");
            DropForeignKey("dbo.TeamStatistics", "shots_blocked_Id", "dbo.ShotsBlockeds");
            DropForeignKey("dbo.TeamStatistics", "offsides_Id", "dbo.Offsides");
            DropForeignKey("dbo.TeamStatistics", "goals_scored_Id", "dbo.GoalsScoreds");
            DropForeignKey("dbo.TeamStatistics", "goals_conceded_Id", "dbo.GoalsConcededs");
            DropForeignKey("dbo.TeamStatistics", "goals_by_head_Id", "dbo.GoalsByHeads");
            DropForeignKey("dbo.TeamStatistics", "goals_by_foot_Id", "dbo.GoalsByFeet");
            DropForeignKey("dbo.TeamStatistics", "goal_attempts_Id", "dbo.GoalAttempts");
            DropForeignKey("dbo.TeamStatistics", "free_kicks_Id", "dbo.FreeKicks");
            DropForeignKey("dbo.TeamStatistics", "corner_kicks_Id", "dbo.CornerKicks");
            DropForeignKey("dbo.TeamStatistics", "cards_given_Id", "dbo.CardsGivens");
            DropForeignKey("dbo.TeamStatistics", "ball_possession_Id", "dbo.BallPossessions");
            DropForeignKey("dbo.TeamProfileModels", "Venue_Id", "dbo.Venues");
            DropForeignKey("dbo.TeamProfileModels", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "Sport_Id", "dbo.Sports");
            DropForeignKey("dbo.Teams", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.TeamProfileModels", "Statistics_Id", "dbo.Statistics");
            DropForeignKey("dbo.Players", "TeamProfileModel_Id", "dbo.TeamProfileModels");
            DropForeignKey("dbo.TeamProfileModels", "Manager_Id", "dbo.Managers");
            DropForeignKey("dbo.Jerseys", "TeamProfileModel_Id", "dbo.TeamProfileModels");
            DropForeignKey("dbo.Seasons", "Statistics_Id1", "dbo.Statistics");
            DropForeignKey("dbo.Seasons", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.Tournaments", "Sport_Id", "dbo.Sport2");
            DropForeignKey("dbo.Tournaments", "Category_Id", "dbo.Category2");
            DropForeignKey("dbo.Seasons", "Statistics_Id", "dbo.Statistics2");
            DropForeignKey("dbo.Seasons", "Form_Id", "dbo.Forms");
            DropForeignKey("dbo.GoaltimeStatistics", "scored_Id", "dbo.Scoreds");
            DropForeignKey("dbo.Periods", "Scored_Id", "dbo.Scoreds");
            DropForeignKey("dbo.GoaltimeStatistics", "conceded_Id", "dbo.Concededs");
            DropForeignKey("dbo.Periods", "Conceded_Id", "dbo.Concededs");
            DropIndex("dbo.TeamStats", new[] { "tournament_Id" });
            DropIndex("dbo.TeamStats", new[] { "team_statistics_Id" });
            DropIndex("dbo.TeamStats", new[] { "team_season_coverage_Id" });
            DropIndex("dbo.TeamStats", new[] { "team_Id" });
            DropIndex("dbo.TeamStats", new[] { "goaltime_statistics_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "shots_on_goal_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "shots_off_goal_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "shots_blocked_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "offsides_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "goals_scored_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "goals_conceded_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "goals_by_head_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "goals_by_foot_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "goal_attempts_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "free_kicks_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "corner_kicks_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "cards_given_Id" });
            DropIndex("dbo.TeamStatistics", new[] { "ball_possession_Id" });
            DropIndex("dbo.Teams", new[] { "Sport_Id" });
            DropIndex("dbo.Teams", new[] { "Category_Id" });
            DropIndex("dbo.TeamProfileModels", new[] { "Venue_Id" });
            DropIndex("dbo.TeamProfileModels", new[] { "Team_Id" });
            DropIndex("dbo.TeamProfileModels", new[] { "Statistics_Id" });
            DropIndex("dbo.TeamProfileModels", new[] { "Manager_Id" });
            DropIndex("dbo.Tournaments", new[] { "Sport_Id" });
            DropIndex("dbo.Tournaments", new[] { "Category_Id" });
            DropIndex("dbo.Seasons", new[] { "Statistics_Id1" });
            DropIndex("dbo.Seasons", new[] { "Tournament_Id" });
            DropIndex("dbo.Seasons", new[] { "Statistics_Id" });
            DropIndex("dbo.Seasons", new[] { "Form_Id" });
            DropIndex("dbo.PlayerStatistics", new[] { "TeamStats_Id" });
            DropIndex("dbo.Players", new[] { "TeamProfileModel_Id" });
            DropIndex("dbo.Jerseys", new[] { "TeamProfileModel_Id" });
            DropIndex("dbo.GoaltimeStatistics", new[] { "scored_Id" });
            DropIndex("dbo.GoaltimeStatistics", new[] { "conceded_Id" });
            DropIndex("dbo.Periods", new[] { "Scored_Id" });
            DropIndex("dbo.Periods", new[] { "Conceded_Id" });
            DropTable("dbo.TeamStats");
            DropTable("dbo.TeamStatistics");
            DropTable("dbo.TeamSeasonCoverages");
            DropTable("dbo.Venues");
            DropTable("dbo.Teams");
            DropTable("dbo.TeamProfileModels");
            DropTable("dbo.Statistics");
            DropTable("dbo.Sports");
            DropTable("dbo.ShotsOnGoals");
            DropTable("dbo.ShotsOffGoals");
            DropTable("dbo.ShotsBlockeds");
            DropTable("dbo.Sport2");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Statistics2");
            DropTable("dbo.Seasons");
            DropTable("dbo.PlayerStatistics");
            DropTable("dbo.Players");
            DropTable("dbo.Offsides");
            DropTable("dbo.Managers");
            DropTable("dbo.Jerseys");
            DropTable("dbo.Scoreds");
            DropTable("dbo.GoaltimeStatistics");
            DropTable("dbo.GoalsScoreds");
            DropTable("dbo.GoalsConcededs");
            DropTable("dbo.GoalsByHeads");
            DropTable("dbo.GoalsByFeet");
            DropTable("dbo.GoalAttempts");
            DropTable("dbo.FreeKicks");
            DropTable("dbo.Forms");
            DropTable("dbo.CurrentSeasons");
            DropTable("dbo.CornerKicks");
            DropTable("dbo.Periods");
            DropTable("dbo.Concededs");
            DropTable("dbo.Category2");
            DropTable("dbo.Categories");
            DropTable("dbo.CardsGivens");
            DropTable("dbo.BallPossessions");
        }
    }
}
