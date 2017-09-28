namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredToTag : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SupervisorStudents", "TagMainOrCo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SupervisorStudents", "TagMainOrCo", c => c.String());
        }
    }
}
