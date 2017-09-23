namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "CourseCode", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Faculties", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "Abstract", c => c.String(nullable: false));
            AlterColumn("dbo.Semesters", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Semesters", "Name", c => c.String());
            AlterColumn("dbo.Projects", "Abstract", c => c.String());
            AlterColumn("dbo.Projects", "Title", c => c.String());
            AlterColumn("dbo.Faculties", "Name", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            AlterColumn("dbo.Courses", "CourseCode", c => c.String());
        }
    }
}
