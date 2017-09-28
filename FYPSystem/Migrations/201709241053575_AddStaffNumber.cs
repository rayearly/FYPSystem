namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStaffNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supervisors", "StaffNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Supervisors", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Supervisors", "Name", c => c.String());
            DropColumn("dbo.Supervisors", "StaffNumber");
        }
    }
}
