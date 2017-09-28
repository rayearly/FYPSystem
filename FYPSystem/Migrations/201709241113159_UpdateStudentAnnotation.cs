namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudentAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "MatricNo", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Students", "MatricNo", c => c.String());
        }
    }
}
