namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCourseCodeInCourseModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CourseCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "CourseCode");
        }
    }
}
