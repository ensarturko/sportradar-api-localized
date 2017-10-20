namespace Oregon.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ensar1432 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamProfileModels",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Generated_at = c.DateTime(nullable: false),
                        Schema = c.String(),
                        Manager_Id = c.String(maxLength: 128),
                        Statistics_Id = c.String(maxLength: 128),
                        Team_Id = c.String(maxLength: 128),
                        Venue_Id = c.String(maxLength: 128),
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
                "dbo.Jerseys",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
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
                        TeamProfileModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TeamProfileModels", t => t.TeamProfileModel_Id)
                .Index(t => t.TeamProfileModel_Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Nationality = c.String(),
                        Country_code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        type = c.String(),
                        Date_of_birth = c.String(),
                        Nationality = c.String(),
                        Country_code = c.String(),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Jersey_number = c.Int(nullable: false),
                        Preferred_foot = c.String(),
                        TeamProfileModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TeamProfileModels", t => t.TeamProfileModel_Id)
                .Index(t => t.TeamProfileModel_Id);
            
            CreateTable(
                "dbo.Statistics",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Form_Id = c.String(maxLength: 128),
                        Statistics_Id = c.String(maxLength: 128),
                        Tournament_Id = c.String(maxLength: 128),
                        Statistics_Id1 = c.String(maxLength: 128),
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
                "dbo.Forms",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Total = c.String(),
                        Home = c.String(),
                        Away = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Statistics2",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Matches_played = c.Int(nullable: false),
                        Matches_won = c.Int(nullable: false),
                        Matches_drawn = c.Int(nullable: false),
                        Matches_lost = c.Int(nullable: false),
                        Goals_scored = c.Int(nullable: false),
                        Goals_conceded = c.Int(nullable: false),
                        Group_position = c.Int(nullable: false),
                        Cup_rank = c.Int(),
                        Group_name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Category_Category2Id = c.Int(),
                        Sport_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category2", t => t.Category_Category2Id)
                .ForeignKey("dbo.Sport2", t => t.Sport_Id)
                .Index(t => t.Category_Category2Id)
                .Index(t => t.Sport_Id);
            
            CreateTable(
                "dbo.Category2",
                c => new
                    {
                        Category2Id = c.Int(nullable: false),
                        Id = c.String(),
                        Name = c.String(),
                        Country_code = c.String(),
                    })
                .PrimaryKey(t => t.Category2Id);
            
            CreateTable(
                "dbo.Sport2",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Country = c.String(),
                        Country_code = c.String(),
                        Abbreviation = c.String(),
                        Category_Id = c.String(maxLength: 128),
                        Sport_Id = c.String(maxLength: 128),
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
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Country_code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Venues",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
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
            DropForeignKey("dbo.Seasons", "Statistics_Id1", "dbo.Statistics");
            DropForeignKey("dbo.Seasons", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.Tournaments", "Sport_Id", "dbo.Sport2");
            DropForeignKey("dbo.Tournaments", "Category_Category2Id", "dbo.Category2");
            DropForeignKey("dbo.Seasons", "Statistics_Id", "dbo.Statistics2");
            DropForeignKey("dbo.Seasons", "Form_Id", "dbo.Forms");
            DropForeignKey("dbo.Players", "TeamProfileModel_Id", "dbo.TeamProfileModels");
            DropForeignKey("dbo.TeamProfileModels", "Manager_Id", "dbo.Managers");
            DropForeignKey("dbo.Jerseys", "TeamProfileModel_Id", "dbo.TeamProfileModels");
            DropIndex("dbo.Teams", new[] { "Sport_Id" });
            DropIndex("dbo.Teams", new[] { "Category_Id" });
            DropIndex("dbo.Tournaments", new[] { "Sport_Id" });
            DropIndex("dbo.Tournaments", new[] { "Category_Category2Id" });
            DropIndex("dbo.Seasons", new[] { "Statistics_Id1" });
            DropIndex("dbo.Seasons", new[] { "Tournament_Id" });
            DropIndex("dbo.Seasons", new[] { "Statistics_Id" });
            DropIndex("dbo.Seasons", new[] { "Form_Id" });
            DropIndex("dbo.Players", new[] { "TeamProfileModel_Id" });
            DropIndex("dbo.Jerseys", new[] { "TeamProfileModel_Id" });
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
            DropTable("dbo.Statistics2");
            DropTable("dbo.Forms");
            DropTable("dbo.Seasons");
            DropTable("dbo.Statistics");
            DropTable("dbo.Players");
            DropTable("dbo.Managers");
            DropTable("dbo.Jerseys");
            DropTable("dbo.TeamProfileModels");
        }
    }
}
