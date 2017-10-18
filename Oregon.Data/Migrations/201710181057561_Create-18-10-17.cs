namespace Oregon.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create181017 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamProfileModels",
                c => new
                    {
                        Generated_at = c.DateTime(nullable: false),
                        Schema = c.String(),
                        Manager_Id = c.Int(),
                        Statistics_Id = c.Int(),
                        Team_Id = c.Int(),
                        Venue_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Generated_at)
                .ForeignKey("dbo.Managers", t => t.Manager_Id)
                .ForeignKey("dbo.Statistics", t => t.Statistics_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.Venues", t => t.Venue_Id)
                .Index(t => t.Manager_Id)
                .Index(t => t.Statistics_Id)
                .Index(t => t.Team_Id)
                .Index(t => t.Venue_Id);
            
            CreateTable(
                "dbo.Jerseys",
                c => new
                    {
                        Type = c.String(nullable: false, maxLength: 128),
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
                        TeamProfileModel_Generated_at = c.DateTime(),
                    })
                .PrimaryKey(t => t.Type)
                .ForeignKey("dbo.TeamProfileModels", t => t.TeamProfileModel_Generated_at)
                .Index(t => t.TeamProfileModel_Generated_at);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Nationality = c.String(),
                        Country_code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        type = c.String(),
                        Date_of_birth = c.String(),
                        Nationality = c.String(),
                        Country_code = c.String(),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Jersey_number = c.Int(nullable: false),
                        Preferred_foot = c.String(),
                        TeamProfileModel_Generated_at = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TeamProfileModels", t => t.TeamProfileModel_Generated_at)
                .Index(t => t.TeamProfileModel_Generated_at);
            
            CreateTable(
                "dbo.Statistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Statistics_Matches_played = c.Int(nullable: false),
                        Statistics_Matches_won = c.Int(nullable: false),
                        Statistics_Matches_drawn = c.Int(nullable: false),
                        Statistics_Matches_lost = c.Int(nullable: false),
                        Statistics_Goals_scored = c.Int(nullable: false),
                        Statistics_Goals_conceded = c.Int(nullable: false),
                        Statistics_Group_position = c.Int(nullable: false),
                        Statistics_Cup_rank = c.Int(),
                        Statistics_Group_name = c.String(),
                        Form_Total = c.String(),
                        Form_Home = c.String(),
                        Form_Away = c.String(),
                        Tournament_Id = c.Int(),
                        Statistics_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id)
                .ForeignKey("dbo.Statistics", t => t.Statistics_Id)
                .Index(t => t.Tournament_Id)
                .Index(t => t.Statistics_Id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                "dbo.Category2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sport2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Country_code = c.String(),
                        Abbreviation = c.String(),
                        Category_Id = c.Int(),
                        Sport_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Sports", t => t.Sport_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Sport_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Venues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Capacity = c.Int(nullable: false),
                        City_name = c.String(),
                        Country_name = c.String(),
                        Map_coordinates = c.String(),
                        Country_code = c.String(),
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
            DropForeignKey("dbo.Seasons", "Statistics_Id", "dbo.Statistics");
            DropForeignKey("dbo.Seasons", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.Tournaments", "Sport_Id", "dbo.Sport2");
            DropForeignKey("dbo.Tournaments", "Category_Id", "dbo.Category2");
            DropForeignKey("dbo.Players", "TeamProfileModel_Generated_at", "dbo.TeamProfileModels");
            DropForeignKey("dbo.TeamProfileModels", "Manager_Id", "dbo.Managers");
            DropForeignKey("dbo.Jerseys", "TeamProfileModel_Generated_at", "dbo.TeamProfileModels");
            DropIndex("dbo.Teams", new[] { "Sport_Id" });
            DropIndex("dbo.Teams", new[] { "Category_Id" });
            DropIndex("dbo.Tournaments", new[] { "Sport_Id" });
            DropIndex("dbo.Tournaments", new[] { "Category_Id" });
            DropIndex("dbo.Seasons", new[] { "Statistics_Id" });
            DropIndex("dbo.Seasons", new[] { "Tournament_Id" });
            DropIndex("dbo.Players", new[] { "TeamProfileModel_Generated_at" });
            DropIndex("dbo.Jerseys", new[] { "TeamProfileModel_Generated_at" });
            DropIndex("dbo.TeamProfileModels", new[] { "Venue_Id" });
            DropIndex("dbo.TeamProfileModels", new[] { "Team_Id" });
            DropIndex("dbo.TeamProfileModels", new[] { "Statistics_Id" });
            DropIndex("dbo.TeamProfileModels", new[] { "Manager_Id" });
            DropTable("dbo.Venues");
            DropTable("dbo.Sports");
            DropTable("dbo.Categories");
            DropTable("dbo.Teams");
            DropTable("dbo.Sport2");
            DropTable("dbo.Category2");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Seasons");
            DropTable("dbo.Statistics");
            DropTable("dbo.Players");
            DropTable("dbo.Managers");
            DropTable("dbo.Jerseys");
            DropTable("dbo.TeamProfileModels");
        }
    }
}
