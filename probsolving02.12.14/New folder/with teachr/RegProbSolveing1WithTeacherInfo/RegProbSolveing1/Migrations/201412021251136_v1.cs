namespace RegProbSolveing1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CourseCode = c.String(nullable: false),
                        CourseName = c.String(nullable: false),
                        Credit = c.Double(nullable: false),
                        Description = c.String(),
                        DepartmentID = c.Int(nullable: false),
                        SemesterID = c.Int(nullable: false),
                        AssignedTo = c.String(),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Semesters", t => t.SemesterID, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.SemesterID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DeptCode = c.String(nullable: false),
                        DeptName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        RegNo = c.String(),
                        StudentName = c.String(nullable: false),
                        Email = c.String(),
                        ContactNo = c.String(),
                        AdmissionDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        ContactNo = c.String(),
                        DepartmentID = c.Int(nullable: false),
                        DesignationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.DesignationId);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        DesignationId = c.Int(nullable: false, identity: true),
                        DesignationName = c.String(),
                    })
                .PrimaryKey(t => t.DesignationId);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        SemesterID = c.Int(nullable: false, identity: true),
                        SemesterName = c.String(),
                    })
                .PrimaryKey(t => t.SemesterID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "SemesterID", "dbo.Semesters");
            DropForeignKey("dbo.Teachers", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.Teachers", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Students", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "SemesterID" });
            DropIndex("dbo.Teachers", new[] { "DesignationId" });
            DropIndex("dbo.Teachers", new[] { "DepartmentID" });
            DropIndex("dbo.Students", new[] { "DepartmentID" });
            DropIndex("dbo.Courses", new[] { "DepartmentID" });
            DropTable("dbo.Semesters");
            DropTable("dbo.Designations");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
        }
    }
}
