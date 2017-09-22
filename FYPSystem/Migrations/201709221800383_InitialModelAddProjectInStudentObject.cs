namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModelAddProjectInStudentObject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ProjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "ProjectId");
            AddForeignKey("dbo.Students", "ProjectId", "dbo.Projects", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Students", new[] { "ProjectId" });
            DropColumn("dbo.Students", "ProjectId");
        }
    }
}
