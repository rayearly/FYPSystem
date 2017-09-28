namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredToSSs : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SupervisorStudents", "TagMainOrCo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SupervisorStudents", "TagMainOrCo", c => c.String(nullable: false));
        }
    }
}
