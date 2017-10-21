namespace Oregon.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _211017 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Seasons", "Form_Id", "dbo.Forms");
            DropIndex("dbo.Seasons", new[] { "Form_Id" });
            AddColumn("dbo.Seasons", "Form_Total", c => c.String());
            AddColumn("dbo.Seasons", "Form_Home", c => c.String());
            AddColumn("dbo.Seasons", "Form_Away", c => c.String());
            DropColumn("dbo.Seasons", "Form_Id");
            DropTable("dbo.Forms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.String(),
                        Home = c.String(),
                        Away = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Seasons", "Form_Id", c => c.Int());
            DropColumn("dbo.Seasons", "Form_Away");
            DropColumn("dbo.Seasons", "Form_Home");
            DropColumn("dbo.Seasons", "Form_Total");
            CreateIndex("dbo.Seasons", "Form_Id");
            AddForeignKey("dbo.Seasons", "Form_Id", "dbo.Forms", "Id");
        }
    }
}
