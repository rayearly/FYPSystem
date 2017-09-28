namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteProjectModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Students", new[] { "ProjectId" });
            AddColumn("dbo.Students", "ProjectTitle", c => c.String());
            AddColumn("dbo.Students", "Abstract", c => c.String());
            DropColumn("dbo.Students", "ProjectId");
            DropTable("dbo.Projects");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Abstract = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "ProjectId", c => c.Int());
            DropColumn("dbo.Students", "Abstract");
            DropColumn("dbo.Students", "ProjectTitle");
            CreateIndex("dbo.Students", "ProjectId");
            AddForeignKey("dbo.Students", "ProjectId", "dbo.Projects", "Id");
        }
    }
}
