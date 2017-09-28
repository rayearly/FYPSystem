namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeProjectIdOptionalInStudentModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Students", new[] { "ProjectId" });
            AlterColumn("dbo.Students", "ProjectId", c => c.Int());
            CreateIndex("dbo.Students", "ProjectId");
            AddForeignKey("dbo.Students", "ProjectId", "dbo.Projects", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Students", new[] { "ProjectId" });
            AlterColumn("dbo.Students", "ProjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "ProjectId");
            AddForeignKey("dbo.Students", "ProjectId", "dbo.Projects", "Id", cascadeDelete: true);
        }
    }
}
