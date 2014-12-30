namespace UniversityWebAppNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllocateClassrooms",
                c => new
                    {
                        AllocateClassRoomID = c.Int(nullable: false, identity: true),
                        DepartmentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                        WeekDaysID = c.Int(nullable: false),
                        FromTime = c.DateTime(nullable: false),
                        ToTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AllocateClassRoomID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: false)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: false)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: false)
                .ForeignKey("dbo.WeekDays", t => t.WeekDaysID, cascadeDelete: false)
                .Index(t => t.DepartmentID)
                .Index(t => t.CourseID)
                .Index(t => t.RoomID)
                .Index(t => t.WeekDaysID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CourseCode = c.String(nullable: false),
                        CourseCredit = c.Double(nullable: false),
                        CourseName = c.String(nullable: false),
                        Description = c.String(maxLength: 150),
                        DepartmentId = c.Int(nullable: false),
                        SemisterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .ForeignKey("dbo.Semisters", t => t.SemisterID, cascadeDelete: false)
                .Index(t => t.DepartmentId)
                .Index(t => t.SemisterID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false),
                        DepartmentCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        RegNo = c.String(),
                        StudentName = c.String(nullable: false),
                        StudentEmail = c.String(),
                        ContactNo = c.String(maxLength: 11),
                        AdmissionDate = c.DateTime(nullable: false),
                        Address = c.String(maxLength: 150),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        TeacherAddress = c.String(maxLength: 150),
                        TeacherEmail = c.String(nullable: false),
                        ContactNo = c.String(maxLength: 11),
                        TeacherCredit = c.Double(nullable: false),
                        DesignationID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: false)
                .ForeignKey("dbo.Designations", t => t.DesignationID, cascadeDelete: false)
                .Index(t => t.DesignationID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.CourseAssigns",
                c => new
                    {
                        CourseAssignID = c.Int(nullable: false, identity: true),
                        DepartmentID = c.Int(nullable: false),
                        TeacherID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseAssignID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: false)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: false)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: false)
                .Index(t => t.DepartmentID)
                .Index(t => t.TeacherID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        DesignationID = c.Int(nullable: false, identity: true),
                        DesignationName = c.String(),
                    })
                .PrimaryKey(t => t.DesignationID);
            
            CreateTable(
                "dbo.Semisters",
                c => new
                    {
                        SemisterID = c.Int(nullable: false, identity: true),
                        SemisterName = c.String(),
                    })
                .PrimaryKey(t => t.SemisterID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        RoomsName = c.String(),
                    })
                .PrimaryKey(t => t.RoomID);
            
            CreateTable(
                "dbo.WeekDays",
                c => new
                    {
                        WeekDaysID = c.Int(nullable: false, identity: true),
                        WeekDayName = c.String(),
                    })
                .PrimaryKey(t => t.WeekDaysID);
            
            CreateTable(
                "dbo.EnrollCourses",
                c => new
                    {
                        EnrollCourseID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        EnrollDate = c.DateTime(nullable: false),
                        Students_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.EnrollCourseID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Students_StudentID)
                .Index(t => t.CourseID)
                .Index(t => t.Students_StudentID);
            
            CreateTable(
                "dbo.GradeLetters",
                c => new
                    {
                        GradeLetterID = c.Int(nullable: false, identity: true),
                        GradeLetterName = c.String(),
                    })
                .PrimaryKey(t => t.GradeLetterID);
            
            CreateTable(
                "dbo.ResultEntries",
                c => new
                    {
                        ResultEntryID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        GradeLatterID = c.Int(nullable: false),
                        GradeLetter_GradeLetterID = c.Int(),
                        Students_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.ResultEntryID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.GradeLetters", t => t.GradeLetter_GradeLetterID)
                .ForeignKey("dbo.Students", t => t.Students_StudentID)
                .Index(t => t.CourseID)
                .Index(t => t.GradeLetter_GradeLetterID)
                .Index(t => t.Students_StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResultEntries", "Students_StudentID", "dbo.Students");
            DropForeignKey("dbo.ResultEntries", "GradeLetter_GradeLetterID", "dbo.GradeLetters");
            DropForeignKey("dbo.ResultEntries", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.EnrollCourses", "Students_StudentID", "dbo.Students");
            DropForeignKey("dbo.EnrollCourses", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.AllocateClassrooms", "WeekDaysID", "dbo.WeekDays");
            DropForeignKey("dbo.AllocateClassrooms", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.AllocateClassrooms", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.AllocateClassrooms", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Courses", "SemisterID", "dbo.Semisters");
            DropForeignKey("dbo.Teachers", "DesignationID", "dbo.Designations");
            DropForeignKey("dbo.Teachers", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.CourseAssigns", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.CourseAssigns", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.CourseAssigns", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Students", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.ResultEntries", new[] { "Students_StudentID" });
            DropIndex("dbo.ResultEntries", new[] { "GradeLetter_GradeLetterID" });
            DropIndex("dbo.ResultEntries", new[] { "CourseID" });
            DropIndex("dbo.EnrollCourses", new[] { "Students_StudentID" });
            DropIndex("dbo.EnrollCourses", new[] { "CourseID" });
            DropIndex("dbo.CourseAssigns", new[] { "CourseID" });
            DropIndex("dbo.CourseAssigns", new[] { "TeacherID" });
            DropIndex("dbo.CourseAssigns", new[] { "DepartmentID" });
            DropIndex("dbo.Teachers", new[] { "DepartmentID" });
            DropIndex("dbo.Teachers", new[] { "DesignationID" });
            DropIndex("dbo.Students", new[] { "DepartmentID" });
            DropIndex("dbo.Courses", new[] { "SemisterID" });
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropIndex("dbo.AllocateClassrooms", new[] { "WeekDaysID" });
            DropIndex("dbo.AllocateClassrooms", new[] { "RoomID" });
            DropIndex("dbo.AllocateClassrooms", new[] { "CourseID" });
            DropIndex("dbo.AllocateClassrooms", new[] { "DepartmentID" });
            DropTable("dbo.ResultEntries");
            DropTable("dbo.GradeLetters");
            DropTable("dbo.EnrollCourses");
            DropTable("dbo.WeekDays");
            DropTable("dbo.Rooms");
            DropTable("dbo.Semisters");
            DropTable("dbo.Designations");
            DropTable("dbo.CourseAssigns");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
            DropTable("dbo.AllocateClassrooms");
        }
    }
}
