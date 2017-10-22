namespace Oregon.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _221017 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
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
            DropIndex("dbo.Players", new[] { "TeamProfileModel_Id" });
            DropIndex("dbo.Jerseys", new[] { "TeamProfileModel_Id" });
            DropTable("dbo.Venues");
            DropTable("dbo.Teams");
            DropTable("dbo.TeamProfileModels");
            DropTable("dbo.Statistics");
            DropTable("dbo.Sports");
            DropTable("dbo.Sport2");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Statistics2");
            DropTable("dbo.Seasons");
            DropTable("dbo.Players");
            DropTable("dbo.Managers");
            DropTable("dbo.Jerseys");
            DropTable("dbo.Forms");
            DropTable("dbo.Category2");
            DropTable("dbo.Categories");
        }
    }
}
