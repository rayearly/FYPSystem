namespace FYPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFacultyCourseSemester : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Faculties (Name) VALUES ('Farming & Argotech')");
            Sql("INSERT INTO Faculties (Name) VALUES ('Applied Science')");
            Sql("INSERT INTO Faculties (Name) VALUES ('Architecture')");
            Sql("INSERT INTO Faculties (Name) VALUES ('Sport Science')");
            Sql("INSERT INTO Faculties (Name) VALUES ('FSKM')");
            Sql("INSERT INTO Faculties (Name) VALUES ('Business Management')");
            Sql("INSERT INTO Faculties (Name) VALUES ('Accounting')");
            Sql("INSERT INTO Faculties (Name) VALUES ('APB')");

            Sql("INSERT INTO Courses (Name) VALUES ('CSC240')");
            Sql("INSERT INTO Courses (Name) VALUES ('CSC245')");
            Sql("INSERT INTO Courses (Name) VALUES ('CSC251')");

            Sql("INSERT INTO Semesters (Name) VALUES ('March 17 - July 17')");
            Sql("INSERT INTO Semesters (Name) VALUES ('Sept 17 - Jan 18')");
            Sql("INSERT INTO Semesters (Name) VALUES ('March 18 - July 18')");
        }
        
        public override void Down()
        {
        }
    }
}
